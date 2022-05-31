using Microsoft.Extensions.Configuration;
using Microsoft.ML;
using Microsoft.ML.Data;
using MLRecommendator.Database;
using MLRecommendator.Database.Models;
using Npgsql;

namespace MLRecommendator.Modeling; 

public class MlService {
    private readonly MalContext _dbContext;
    private readonly IConfiguration _configuration;

    public MlService(MalContext dbContext, IConfiguration configuration) {
        _dbContext = dbContext;
        _configuration = configuration;
    }

    public async Task<List<Summary>> UserModel(string username) {
        var mlContext = new MLContext();
        var loader = mlContext.Data.CreateDatabaseLoader<UserScoring>();
        var source = new DatabaseSource(NpgsqlFactory.Instance, _configuration.GetConnectionString("Postgresql"),
            $"SELECT * FROM \"UserScorings\" WHERE \"UserId\" = '{username}'");
        var dataView = loader.Load(source);
        var pipeline = mlContext.Transforms.DropColumns("SeriesId", "UserId", "Id");
        var transformedData = pipeline.Fit(dataView).Transform(dataView);
        var dataPrepEstimator = mlContext.Transforms
            .Concatenate("Features",
                "Action", "Adventure", "AvantGarde", "AwardWinning", "BoysLove", "Comedy", "Drama", "Fantasy",
                "GirlsLove", "Gourmet", "Horror", "Mystery", "Romance", "SciFi", "SliceOfLife", "Sports", "Supernatural", "Suspense",
                "Ecchi", "Erotica", "Hentai", "AdultCast", "Anthropomorphic", "CGDCT", "Childcare", "CombatSports", "Crossdressing", 
                "Delinquents", "Detective", "Educational", "GagHumor", "Gore", "Harem", "HighStakesGame", "Historical", "IdolsFemale", 
                "IdolsMale", "Isekai", "Iyashikei", "LovePolygon", "MagicalSexShift", "MahouShoujo", "MartialArts", "Mecha", "Medical", 
                "Military", "Music", "Mythology", "OrganizedCrime", "OtakuCulture", "Parody", "PerformingArts", "Pets", "Psychological",
                "Racing", "Reincarnation", "ReverseHarem", "RomanticSubtext", "Samurai", "School", "Showbiz", "Space", "StrategyGame", 
                "SuperPower", "Survival", "TeamSports", "TimeTravel", "Vampire", "VideoGame", "VisualArts", "Workplace", "Josei", "Kids",
                "Seinen", "Shoujo", "Shounen")
            .AppendCacheCheckpoint(mlContext);
        var dataPrepTransformer = dataPrepEstimator.Fit(transformedData);
        var transformedTrainingData = dataPrepTransformer.Transform(transformedData);
        var pipeLine = dataPrepEstimator.Append(mlContext.Regression.Trainers.LbfgsPoissonRegression("UserScore"));
        var trainedModel = pipeLine.Fit(transformedTrainingData);
        var predictionEngine = mlContext.Model.CreatePredictionEngine<Anime, Prediction>(trainedModel);
        var userSeries = _dbContext.UserSeries.ToList();
        var animes = _dbContext.Animes.ToList();
        var predictions = _dbContext.Animes
            .AsEnumerable()
            .Where(x => !userSeries.Any(y => y.SeriesId == x.SeriesId && y.UserId == username))
            .Select(x => predictionEngine.Predict(x))
            .Select(x => new Summary {
                Id = x.SeriesId,
                Name = animes.First(y => y.SeriesId == x.SeriesId).Title,
                Url = $"https://myanimelist.net/anime/{x.SeriesId}/",
                Description = animes.First(y => y.SeriesId == x.SeriesId).Synopsis,
                ImageUrl = animes.First(y => y.SeriesId == x.SeriesId).ImageUrl,
                StartDate = animes.First(y => y.SeriesId == x.SeriesId).StartDate,
                Genres = animes.First(y => y.SeriesId == x.SeriesId).Genres!.Split("|"),
                PredictedScore = x.PredictedScore * animes.First(y => y.SeriesId == x.SeriesId).Mean
            })
            .OrderByDescending(x => x.PredictedScore)
            .Take(10)
            .ToList();
        return predictions;
    }
}