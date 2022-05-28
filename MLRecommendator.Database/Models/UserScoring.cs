using Microsoft.ML.Data;

namespace MLRecommendator.Database.Models; 

public class UserScoring {
    public uint Id { get; set; }
    public float UserScore { get; set; }
    public float Action { get; set; }
    public float Adventure { get; set; }
    public float AvantGarde { get; set; }
    public float AwardWinning { get; set; }
    public float BoysLove { get; set; }
    public float Comedy { get; set; }
    public float Drama { get; set; }
    public float Fantasy { get; set; }
    public float GirlsLove { get; set; }
    public float Gourmet { get; set; }
    public float Horror { get; set; }
    public float Mystery { get; set; }
    public float Romance { get; set; }
    public float SciFi { get; set; }
    public float SliceOfLife { get; set; }
    public float Sports { get; set; }
    public float Supernatural { get; set; }
    public float Suspense { get; set; }

    //Explicit Genres
    public float Ecchi { get; set; }
    public float Erotica { get; set; }
    public float Hentai { get; set; }

    //Themes
    public float AdultCast { get; set; }
    public float Anthropomorphic { get; set; }
    public float CGDCT { get; set; }
    public float Childcare { get; set; }
    public float CombatSports { get; set; }
    public float Crossdressing { get; set; }
    public float Delinquents { get; set; }
    public float Detective { get; set; }
    public float Educational { get; set; }
    public float GagHumor { get; set; }
    public float Gore { get; set; }
    public float Harem { get; set; }
    public float HighStakesGame { get; set; }
    public float Historical { get; set; }
    public float IdolsFemale { get; set; }
    public float IdolsMale { get; set; }
    public float Isekai { get; set; }
    public float Iyashikei { get; set; }
    public float LovePolygon { get; set; }
    public float MagicalSexShift { get; set; }
    public float MahouShoujo { get; set; }
    public float MartialArts { get; set; }
    public float Mecha { get; set; }
    public float Medical { get; set; }
    public float Military { get; set; }
    public float Music { get; set; }
    public float Mythology { get; set; }
    public float OrganizedCrime { get; set; }
    public float OtakuCulture { get; set; }
    public float Parody { get; set; }
    public float PerformingArts { get; set; }
    public float Pets { get; set; }
    public float Psychological { get; set; }
    public float Racing { get; set; }
    public float Reincarnation { get; set; }
    public float ReverseHarem { get; set; }
    public float RomanticSubtext { get; set; }
    public float Samurai { get; set; }
    public float School { get; set; }
    public float Showbiz { get; set; }
    public float Space { get; set; }
    public float StrategyGame { get; set; }
    public float SuperPower { get; set; }
    public float Survival { get; set; }
    public float TeamSports { get; set; }
    public float TimeTravel { get; set; }
    public float Vampire { get; set; }
    public float VideoGame { get; set; }
    public float VisualArts { get; set; }
    public float Workplace { get; set; }

    //Demographics
    public float Josei { get; set; }
    public float Kids { get; set; }
    public float Seinen { get; set; }
    public float Shoujo { get; set; }
    public float Shounen { get; set; }
}