using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MLRecommendator.Database;
using MLRecommendator.Database.Models;
using MLRecommendator.Modeling;

namespace MLRecommendator.Api.Controllers; 

[Route("api/[controller]")]
[ApiController]
public class ModelController : ControllerBase
{
    private readonly MlService _mlService;
    private readonly MalContext _context;
    public ModelController(MlService service, MalContext context) {
        _mlService = service;
        _context = context;
    }

    [HttpGet]
    [Route("/userModel")]
    [AllowAnonymous]
    public async Task<IActionResult> GetUserModel()
    {
        try {
            _context.UserScorings.RemoveRange(_context.UserScorings);
        }
        catch (Exception) {
            // ignored
        }

        foreach (var userSeries in _context.UserSeries)
        {
            var anime = _context.Animes.FirstOrDefault(x => userSeries.Id == x.Id);
            if (anime == null || userSeries.Score == 0) {
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
        return Ok();
        //return Ok(_mlService.UserModel());
    }

    [HttpGet]
    [Route("/Predict")]
    public IActionResult GetPredictions() {
        return Ok(_mlService.Predict());
    }
}