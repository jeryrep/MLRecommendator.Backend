namespace MLRecommendator.Database.Models;
public class Anime {
    
    public uint Id { get; set; }
    public string? Title { get; set; }
    public float Mean { get; set; }
    public uint Rank { get; set; }
    public uint Popularity { get; set; }
    public uint UsersNumber { get; set; }
    public uint UsersScoringNumber { get; set; }
    public string? Nsfw { get; set; }
    public string? StartDate { get; set; }
    public string? ImageUrl { get; set; }
    public string? Synopsis { get; set; }
    private string? _genres;
    public string? Genres {
        get => _genres;
        set {
            _genres = value;

            //Genres
            Action = Convert.ToByte(_genres.Contains("Action"));
            Adventure = Convert.ToByte(_genres.Contains("Adventure"));
            AvantGarde = Convert.ToByte(_genres.Contains("Avant Garde"));
            AwardWinning = Convert.ToByte(_genres.Contains("Award Winning"));
            BoysLove = Convert.ToByte(_genres.Contains("Boys Love"));
            Comedy = Convert.ToByte(_genres.Contains("Comedy"));
            Drama = Convert.ToByte(_genres.Contains("Drama"));
            Fantasy = Convert.ToByte(_genres.Contains("Fantasy"));
            GirlsLove = Convert.ToByte(_genres.Contains("Girls Love"));
            Gourmet = Convert.ToByte(_genres.Contains("Gourmet"));
            Horror = Convert.ToByte(_genres.Contains("Horror"));
            Mystery = Convert.ToByte(_genres.Contains("Mystery"));
            Romance = Convert.ToByte(_genres.Contains("Romance"));
            SciFi = Convert.ToByte(_genres.Contains("Sci-Fi"));
            SliceOfLife = Convert.ToByte(_genres.Contains("Slice of Life"));
            Sports = Convert.ToByte(_genres.Contains("Sports"));
            Supernatural = Convert.ToByte(_genres.Contains("Supernatural"));
            Suspense = Convert.ToByte(_genres.Contains("Suspense"));

            //Explicit Genres
            Ecchi = Convert.ToByte(_genres.Contains("Ecchi"));
            Erotica = Convert.ToByte(_genres.Contains("Erotica"));
            Hentai = Convert.ToByte(_genres.Contains("Hentai"));

            //Themes
            AdultCast = Convert.ToByte(_genres.Contains("Adult Cast"));
            Anthropomorphic = Convert.ToByte(_genres.Contains("Anthropomorphic"));
            CGDCT = Convert.ToByte(_genres.Contains("CGDCT"));
            Childcare = Convert.ToByte(_genres.Contains("Childcare"));
            CombatSports = Convert.ToByte(_genres.Contains("Combat Sports"));
            Crossdressing = Convert.ToByte(_genres.Contains("Crossdressing"));
            Delinquents = Convert.ToByte(_genres.Contains("Delinquents"));
            Detective = Convert.ToByte(_genres.Contains("Detective"));
            Educational = Convert.ToByte(_genres.Contains("Educational"));
            GagHumor = Convert.ToByte(_genres.Contains("Gag Humor"));
            Gore = Convert.ToByte(_genres.Contains("Gore"));
            Harem = Convert.ToByte(_genres.Contains("Harem"));
            HighStakesGame = Convert.ToByte(_genres.Contains("High Stakes Game"));
            Historical = Convert.ToByte(_genres.Contains("Historical"));
            IdolsFemale = Convert.ToByte(_genres.Contains("Idols (Female)"));
            IdolsMale = Convert.ToByte(_genres.Contains("Idols (Male)"));
            Isekai = Convert.ToByte(_genres.Contains("Isekai"));
            Iyashikei = Convert.ToByte(_genres.Contains("Iyashikei"));
            LovePolygon = Convert.ToByte(_genres.Contains("Love Polygon"));
            MagicalSexShift = Convert.ToByte(_genres.Contains("Magical Sex Shift"));
            MahouShoujo = Convert.ToByte(_genres.Contains("Mahou Shoujo"));
            MartialArts = Convert.ToByte(_genres.Contains("Martial Arts"));
            Mecha = Convert.ToByte(_genres.Contains("Mecha"));
            Medical = Convert.ToByte(_genres.Contains("Medical"));
            Military = Convert.ToByte(_genres.Contains("Military"));
            Music = Convert.ToByte(_genres.Contains("Music"));
            Mythology = Convert.ToByte(_genres.Contains("Mythology"));
            OrganizedCrime = Convert.ToByte(_genres.Contains("Organized Crime"));
            OtakuCulture = Convert.ToByte(_genres.Contains("Otaku Culture"));
            Parody = Convert.ToByte(_genres.Contains("Parody"));
            PerformingArts = Convert.ToByte(_genres.Contains("Performing Arts"));
            Pets = Convert.ToByte(_genres.Contains("Pets"));
            Psychological = Convert.ToByte(_genres.Contains("Psychological"));
            Racing = Convert.ToByte(_genres.Contains("Racing"));
            Reincarnation = Convert.ToByte(_genres.Contains("Reincarnation"));
            ReverseHarem = Convert.ToByte(_genres.Contains("Reverse Harem"));
            RomanticSubtext = Convert.ToByte(_genres.Contains("Romantic Subtext"));
            Samurai = Convert.ToByte(_genres.Contains("Samurai"));
            School = Convert.ToByte(_genres.Contains("School"));
            Showbiz = Convert.ToByte(_genres.Contains("Showbiz"));
            Space = Convert.ToByte(_genres.Contains("Space"));
            StrategyGame = Convert.ToByte(_genres.Contains("Strategy Game"));
            SuperPower = Convert.ToByte(_genres.Contains("Super Power"));
            Survival = Convert.ToByte(_genres.Contains("Survival"));
            TeamSports = Convert.ToByte(_genres.Contains("Team Sports"));
            TimeTravel = Convert.ToByte(_genres.Contains("Time Travel"));
            Vampire = Convert.ToByte(_genres.Contains("Vampire"));
            VideoGame = Convert.ToByte(_genres.Contains("Video Game"));
            VisualArts = Convert.ToByte(_genres.Contains("Visual Arts"));
            Workplace = Convert.ToByte(_genres.Contains("Workplace"));

            //Demographics
            Josei = Convert.ToByte(_genres.Contains("Josei"));
            Kids = Convert.ToByte(_genres.Contains("Kids"));
            Seinen = Convert.ToByte(_genres.Contains("Seinen"));
            Shoujo = Convert.ToByte(_genres.Contains("Shoujo"));
            Shounen = Convert.ToByte(_genres.Contains("Shounen"));
        }
    }

    public ushort EpisodeNumber { get; set; }
    //public DateTime? StartDate { get; set; }
    //public DateTime? EndDate { get; set; }
    public string? Status { get; set; }
    public string? Studios { get; set; }
    public string? Source { get; set; }
    public ushort AverageEpisodeDuration { get; set; }
    public string? Rating { get; set; }

    //Genres
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