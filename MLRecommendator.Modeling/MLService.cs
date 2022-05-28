using System.Data;
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
    public Object DatasetModel() {
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
            .Concatenate("Features",
                "Action", "Adventure", "AvantGarde", "AwardWinning", "BoysLove", "Comedy", "Drama", "Fantasy",
                "GirlsLove", "Gourmet", "Horror",
                "Mystery", "Romance", "SciFi", "SliceOfLife", "Sports", "Supernatural", "Suspense", "Ecchi", "Erotica",
                "Hentai", "AdultCast", "Anthropomorphic", "CGDCT",
                "Childcare", "CombatSports", "Crossdressing", "Delinquents", "Detective", "Educational", "GagHumor",
                "Gore", "Harem", "HighStakesGame", "Historical",
                "IdolsFemale", "IdolsMale", "Isekai", "Iyashikei", "LovePolygon", "MagicalSexShift", "MahouShoujo",
                "MartialArts", "Mecha", "Medical", "Military", "Music",
                "Mythology", "OrganizedCrime", "OtakuCulture", "Parody", "PerformingArts", "Pets", "Psychological",
                "Racing", "Reincarnation", "ReverseHarem",
                "RomanticSubtext", "Samurai", "School", "Showbiz", "Space", "StrategyGame", "SuperPower", "Survival",
                "TeamSports", "TimeTravel", "Vampire", "VideoGame",
                "VisualArts", "Workplace", "Josei", "Kids", "Seinen", "Shoujo", "Shounen")
            .AppendCacheCheckpoint(mlContext)
            .Append(mlContext.Regression.Trainers.Sdca(labelColumnName:"Mean"));
        var dataPrepTransformer = dataPrepEstimator.Fit(trainData);
        var transformedTrainingData = dataPrepTransformer.Transform(trainData);
        var model = dataPrepEstimator.Fit(transformedTrainingData);
        var transformedTestData = dataPrepTransformer.Transform(testData);
        var testDataPredictions = model.Transform(transformedTestData);
        var metrics = mlContext.Regression.Evaluate(testDataPredictions, "Mean");
        return metrics;
    }

    public Object UserModel() {
        var mlContext = new MLContext();
        var loader = mlContext.Data.CreateDatabaseLoader<UserScoring>();
        var source = new DatabaseSource(SqliteFactory.Instance, $"Data Source={_dbContext.DbPath}",
            "SELECT * FROM UserScorings");
        var dataView = loader.Load(source);
        var pipeline = mlContext.Transforms.DropColumns("Id");
        var transformedData = pipeline.Fit(dataView).Transform(dataView);
        var dataSplit = mlContext.Data.TrainTestSplit(transformedData);
        var trainData = dataSplit.TrainSet;
        var testData = dataSplit.TestSet;
        var dataPrepEstimator = mlContext.Transforms
            .Concatenate("Features",
                "Action", "Adventure", "AvantGarde", "AwardWinning", "BoysLove", "Comedy", "Drama", "Fantasy",
                "GirlsLove", "Gourmet", "Horror",
                "Mystery", "Romance", "SciFi", "SliceOfLife", "Sports", "Supernatural", "Suspense", "Ecchi", "Erotica",
                "Hentai", "AdultCast", "Anthropomorphic", "CGDCT",
                "Childcare", "CombatSports", "Crossdressing", "Delinquents", "Detective", "Educational", "GagHumor",
                "Gore", "Harem", "HighStakesGame", "Historical",
                "IdolsFemale", "IdolsMale", "Isekai", "Iyashikei", "LovePolygon", "MagicalSexShift", "MahouShoujo",
                "MartialArts", "Mecha", "Medical", "Military", "Music",
                "Mythology", "OrganizedCrime", "OtakuCulture", "Parody", "PerformingArts", "Pets", "Psychological",
                "Racing", "Reincarnation", "ReverseHarem",
                "RomanticSubtext", "Samurai", "School", "Showbiz", "Space", "StrategyGame", "SuperPower", "Survival",
                "TeamSports", "TimeTravel", "Vampire", "VideoGame",
                "VisualArts", "Workplace", "Josei", "Kids", "Seinen", "Shoujo", "Shounen")
            //.Append(mlContext.Transforms.NormalizeMinMax("Features"))
            .AppendCacheCheckpoint(mlContext);
            //.Append(mlContext.Regression.Trainers.FastForest(labelColumnName: "UserScore"));
        var dataPrepTransformer = dataPrepEstimator.Fit(trainData);
        var transformedTrainingData = dataPrepTransformer.Transform(trainData);
        var transformedTestData = dataPrepTransformer.Transform(testData);
        var pipeLine = dataPrepEstimator.Append(mlContext.Regression.Trainers.LightGbm("UserScore"));
        var trainedModel = pipeLine.Fit(transformedTrainingData);
        var modelDataView = trainedModel.Transform(dataView);
        mlContext.Model.Save(trainedModel, modelDataView.Schema, "model.zip");
        var predictions = trainedModel.Transform(transformedTestData);
        return mlContext.Regression.Evaluate(predictions, "UserScore");
    }

    public List<Prediction> Predict() {
        var mlContext = new MLContext();
        var pipeline = mlContext.Model.Load("model.zip", out var pipelineSchema);
        var predictionEngine = mlContext.Model.CreatePredictionEngine<Anime, Prediction>(pipeline);
        var predictions = _dbContext.Animes
            .AsEnumerable()
            .Where(x => !_dbContext.UserScorings.Any(y => y.Id == x.Id))
            .Select(x => predictionEngine.Predict(x))
            .Select(x => new Prediction {
                Id = x.Id,
                PredictedScore = x.PredictedScore * _dbContext.Animes.First(y => y.Id == x.Id).Mean
            })
            .OrderByDescending(x => x.PredictedScore)
            .Take(10)
            .ToList();
        return predictions;
    }
}