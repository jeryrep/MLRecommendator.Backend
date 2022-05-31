using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MLRecommendator.Database;
using MLRecommendator.Database.Models;
using MLRecommendator.Modeling;
using Newtonsoft.Json;

namespace MLRecommendator.Api.Controllers; 

[Route("api/[controller]")]
[ApiController]
public class MalController : ControllerBase {
    private readonly HttpClient _client;
    private readonly MalContext _context;
    private readonly MlService _service;

    public MalController(MalContext context, IConfiguration configuration, MlService service) {
        _client = new HttpClient {
            BaseAddress = new Uri("https://api.myanimelist.net/v2/")
        };
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _client.DefaultRequestHeaders.Add("X-MAL-CLIENT-ID", configuration["MalToken"]);
        _context = context;
        _service = service;
    }
    // GET: api/Mal
    [HttpPost]
    [AllowAnonymous]
    public async Task<ActionResult> Get() {
        var message = await _client.GetAsync("anime/ranking?ranking_type=all&limit=500&fields=id,title,start_date,mean,rank,popularity,num_list_users,num_scoring_users,nsfw,status,genres,num_episodes,synopsis,source,average_episode_duration,rating,studios&offset=1500");
        if (!message.IsSuccessStatusCode) 
            return BadRequest();
        var content = await message.Content.ReadAsStringAsync();
        dynamic json = JsonConvert.DeserializeObject(content)!;
        var data = json.data;
        foreach (var node in data) {
            var anime = node.node;
            if (anime.genres == null) continue;
            var series = new Anime {
                Id = anime.id,
                Title = anime.title,
                Mean = anime.mean,
                Rank = anime.rank,
                Popularity = anime.popularity,
                UsersNumber = anime.num_list_users,
                UsersScoringNumber = anime.num_scoring_users,
                Nsfw = anime.nsfw,
                EpisodeNumber = anime.num_episodes,
                ImageUrl = anime.main_picture.large,
                Synopsis = anime.synopsis,
                StartDate = anime.start_date,
                Status = anime.status,
                Source = anime.source,
                AverageEpisodeDuration = anime.average_episode_duration,
                Rating = anime.rating
            };
            var sb = new StringBuilder();
            try {
                foreach (var genre in anime.genres) sb.Append($"{genre.name}|");
                sb.Length--;
                series.Genres = sb.ToString();
            }
            catch (Exception) {
                // ignored
            }
            sb.Clear();
            try {
                foreach (var studio in anime.studios) sb.Append($"{studio.name}|");
                sb.Length--;
                series.Studios = sb.ToString();
            }
            catch (Exception) {
                // ignored
            }
            
            _context.Add(series);
        }
        await _context.SaveChangesAsync();
        return Ok();
    }

    //GET api/Mal/5
    [HttpGet("User/{username}")]
    [AllowAnonymous]
    public async Task<ActionResult> GetUser(string username) {
        var message = await _client.GetAsync($"users/{username}/animelist?fields=list_status&limit=1000");
        if (!message.IsSuccessStatusCode) return BadRequest("Error in fetching data");
        try {
            _context.UserSeries.RemoveRange(_context.UserSeries);
        }
        catch (Exception) {
            // ignored
        }

        var content = await message.Content.ReadAsStringAsync();
        dynamic json = JsonConvert.DeserializeObject(content)!;
        var data = json.data;
        foreach (var serie in data) {
            var userSerie = new UserSerie {
                UserId = username,
                Id = serie.node.id,
                Score = serie.list_status.score
            };
            _context.Add(userSerie);
        }
        await _context.SaveChangesAsync();

        try
        {
            _context.UserScorings.RemoveRange(_context.UserScorings);
        }
        catch (Exception)
        {
            // ignored
        }

        foreach (var userSeries in _context.UserSeries)
        {
            var anime = _context.Animes.FirstOrDefault(x => userSeries.Id == x.Id);
            if (anime == null || userSeries.Score == 0)
            {
                continue;
            }
            _context.UserScorings.Add(new UserScoring
            {
                Id = anime.Id,
                UserScore = userSeries.Score,
                Action = anime.Action,
                Adventure = anime.Adventure,
                AvantGarde = anime.AvantGarde,
                AwardWinning = anime.AwardWinning,
                BoysLove = anime.BoysLove,
                Comedy = anime.Comedy,
                Drama = anime.Drama,
                Fantasy = anime.Fantasy,
                GirlsLove = anime.GirlsLove,
                Gourmet = anime.Gourmet,
                Horror = anime.Horror,
                Mystery = anime.Mystery,
                Romance = anime.Romance,
                SciFi = anime.SciFi,
                SliceOfLife = anime.SliceOfLife,
                Sports = anime.Sports,
                Supernatural = anime.Supernatural,
                Suspense = anime.Suspense,
                Ecchi = anime.Ecchi,
                Erotica = anime.Erotica,
                Hentai = anime.Hentai,
                AdultCast = anime.AdultCast,
                Anthropomorphic = anime.Anthropomorphic,
                CGDCT = anime.CGDCT,
                Childcare = anime.Childcare,
                CombatSports = anime.CombatSports,
                Crossdressing = anime.Crossdressing,
                Delinquents = anime.Delinquents,
                Detective = anime.Detective,
                Educational = anime.Educational,
                GagHumor = anime.GagHumor,
                Gore = anime.Gore,
                Harem = anime.Harem,
                HighStakesGame = anime.HighStakesGame,
                Historical = anime.Historical,
                IdolsFemale = anime.IdolsFemale,
                IdolsMale = anime.IdolsMale,
                Isekai = anime.Isekai,
                Iyashikei = anime.Iyashikei,
                LovePolygon = anime.LovePolygon,
                MagicalSexShift = anime.MagicalSexShift,
                MahouShoujo = anime.MahouShoujo,
                MartialArts = anime.MartialArts,
                Mecha = anime.Mecha,
                Medical = anime.Medical,
                Military = anime.Military,
                Music = anime.Music,
                Mythology = anime.Mythology,
                OrganizedCrime = anime.OrganizedCrime,
                OtakuCulture = anime.OtakuCulture,
                Parody = anime.Parody,
                PerformingArts = anime.PerformingArts,
                Pets = anime.Pets,
                Psychological = anime.Psychological,
                Racing = anime.Racing,
                Reincarnation = anime.Reincarnation,
                ReverseHarem = anime.ReverseHarem,
                RomanticSubtext = anime.RomanticSubtext,
                Samurai = anime.Samurai,
                School = anime.School,
                Showbiz = anime.Showbiz,
                Space = anime.Space,
                StrategyGame = anime.StrategyGame,
                SuperPower = anime.SuperPower,
                Survival = anime.Survival,
                TeamSports = anime.TeamSports,
                TimeTravel = anime.TimeTravel,
                Vampire = anime.Vampire,
                VideoGame = anime.VideoGame,
                VisualArts = anime.VisualArts,
                Workplace = anime.Workplace,
                Josei = anime.Josei,
                Kids = anime.Kids,
                Seinen = anime.Seinen,
                Shoujo = anime.Shoujo,
                Shounen = anime.Shounen
            });
        }
        await _context.SaveChangesAsync();
        _service.UserModel();
        return Ok(_service.Predict());
    }
}