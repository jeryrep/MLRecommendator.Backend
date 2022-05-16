using Microsoft.Data.Sqlite;
using Microsoft.ML;
using Microsoft.ML.Data;
using MLRecommendator.Database;
using MLRecommendator.Database.Models;

namespace MLRecommendator.Modeling; 

public class MlService {
    private readonly MalContext _dbContext;
    public MlService(MalContext dbContext) {
        _dbContext = dbContext;
    }
    public double GetBias() {
        var mlContext = new MLContext();
        var loader = mlContext.Data.CreateDatabaseLoader<Anime>();
        var source = new DatabaseSource(SqliteFactory.Instance, $"Data Source={_dbContext.DbPath}", "SELECT * FROM Animes");
        var dataView = loader.Load(source);
        var pipeline = mlContext.Transforms.DropColumns(/*"StartDate", "EndDate",*/ "Status", "Studios", "Source", "AverageEpisodeDuration", "Rating");
        var transformedData = pipeline.Fit(dataView).Transform(dataView);
        var dataSplit = mlContext.Data.TrainTestSplit(transformedData, 0.2);
        var trainData = dataSplit.TrainSet;
        var testData = dataSplit.TestSet;
        var dataPrepEstimator = mlContext.Transforms
            .Concatenate(
                "Features", /*"Id", /*"Title",#1# "Rank", "Popularity", "UsersNumber", "UsersScoringNumber", /*"Nsfw",#1#*/
                "Action", "AdultCast", "Adventure", "SciFi", "Space", "Comedy", "Drama", "Shounen",
                "Mystery", "Psychological", "Seinen", "Fantasy", "Romance", "Military", "Ecchi", "SliceOfLife",
                "School", "Historical", "Isekai" /*"Mean"/*, "Popularity"*/)
            .Append(mlContext.Transforms.NormalizeMinMax("Features"))
            .AppendCacheCheckpoint(mlContext)
            .Append(mlContext.Regression.Trainers.Sdca(labelColumnName:"Mean"));
        var dataPrepTransformer = dataPrepEstimator.Fit(trainData);
        var transformedTrainingData = dataPrepTransformer.Transform(trainData);
        var model = dataPrepEstimator.Fit(transformedTrainingData);
        var transformedTestData = dataPrepTransformer.Transform(testData);
        var testDataPredictions = model.Transform(transformedTestData);
        var metrics = mlContext.Regression.Evaluate(testDataPredictions, "Mean");
        return metrics.RSquared;
    }
}