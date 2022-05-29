using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MLRecommendator.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Mean = table.Column<float>(type: "REAL", nullable: false),
                    Rank = table.Column<uint>(type: "INTEGER", nullable: false),
                    Popularity = table.Column<uint>(type: "INTEGER", nullable: false),
                    UsersNumber = table.Column<uint>(type: "INTEGER", nullable: false),
                    UsersScoringNumber = table.Column<uint>(type: "INTEGER", nullable: false),
                    Nsfw = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Synopsis = table.Column<string>(type: "TEXT", nullable: true),
                    Genres = table.Column<string>(type: "TEXT", nullable: true),
                    EpisodeNumber = table.Column<ushort>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Studios = table.Column<string>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    AverageEpisodeDuration = table.Column<ushort>(type: "INTEGER", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: true),
                    Action = table.Column<float>(type: "REAL", nullable: false),
                    Adventure = table.Column<float>(type: "REAL", nullable: false),
                    AvantGarde = table.Column<float>(type: "REAL", nullable: false),
                    AwardWinning = table.Column<float>(type: "REAL", nullable: false),
                    BoysLove = table.Column<float>(type: "REAL", nullable: false),
                    Comedy = table.Column<float>(type: "REAL", nullable: false),
                    Drama = table.Column<float>(type: "REAL", nullable: false),
                    Fantasy = table.Column<float>(type: "REAL", nullable: false),
                    GirlsLove = table.Column<float>(type: "REAL", nullable: false),
                    Gourmet = table.Column<float>(type: "REAL", nullable: false),
                    Horror = table.Column<float>(type: "REAL", nullable: false),
                    Mystery = table.Column<float>(type: "REAL", nullable: false),
                    Romance = table.Column<float>(type: "REAL", nullable: false),
                    SciFi = table.Column<float>(type: "REAL", nullable: false),
                    SliceOfLife = table.Column<float>(type: "REAL", nullable: false),
                    Sports = table.Column<float>(type: "REAL", nullable: false),
                    Supernatural = table.Column<float>(type: "REAL", nullable: false),
                    Suspense = table.Column<float>(type: "REAL", nullable: false),
                    Ecchi = table.Column<float>(type: "REAL", nullable: false),
                    Erotica = table.Column<float>(type: "REAL", nullable: false),
                    Hentai = table.Column<float>(type: "REAL", nullable: false),
                    AdultCast = table.Column<float>(type: "REAL", nullable: false),
                    Anthropomorphic = table.Column<float>(type: "REAL", nullable: false),
                    CGDCT = table.Column<float>(type: "REAL", nullable: false),
                    Childcare = table.Column<float>(type: "REAL", nullable: false),
                    CombatSports = table.Column<float>(type: "REAL", nullable: false),
                    Crossdressing = table.Column<float>(type: "REAL", nullable: false),
                    Delinquents = table.Column<float>(type: "REAL", nullable: false),
                    Detective = table.Column<float>(type: "REAL", nullable: false),
                    Educational = table.Column<float>(type: "REAL", nullable: false),
                    GagHumor = table.Column<float>(type: "REAL", nullable: false),
                    Gore = table.Column<float>(type: "REAL", nullable: false),
                    Harem = table.Column<float>(type: "REAL", nullable: false),
                    HighStakesGame = table.Column<float>(type: "REAL", nullable: false),
                    Historical = table.Column<float>(type: "REAL", nullable: false),
                    IdolsFemale = table.Column<float>(type: "REAL", nullable: false),
                    IdolsMale = table.Column<float>(type: "REAL", nullable: false),
                    Isekai = table.Column<float>(type: "REAL", nullable: false),
                    Iyashikei = table.Column<float>(type: "REAL", nullable: false),
                    LovePolygon = table.Column<float>(type: "REAL", nullable: false),
                    MagicalSexShift = table.Column<float>(type: "REAL", nullable: false),
                    MahouShoujo = table.Column<float>(type: "REAL", nullable: false),
                    MartialArts = table.Column<float>(type: "REAL", nullable: false),
                    Mecha = table.Column<float>(type: "REAL", nullable: false),
                    Medical = table.Column<float>(type: "REAL", nullable: false),
                    Military = table.Column<float>(type: "REAL", nullable: false),
                    Music = table.Column<float>(type: "REAL", nullable: false),
                    Mythology = table.Column<float>(type: "REAL", nullable: false),
                    OrganizedCrime = table.Column<float>(type: "REAL", nullable: false),
                    OtakuCulture = table.Column<float>(type: "REAL", nullable: false),
                    Parody = table.Column<float>(type: "REAL", nullable: false),
                    PerformingArts = table.Column<float>(type: "REAL", nullable: false),
                    Pets = table.Column<float>(type: "REAL", nullable: false),
                    Psychological = table.Column<float>(type: "REAL", nullable: false),
                    Racing = table.Column<float>(type: "REAL", nullable: false),
                    Reincarnation = table.Column<float>(type: "REAL", nullable: false),
                    ReverseHarem = table.Column<float>(type: "REAL", nullable: false),
                    RomanticSubtext = table.Column<float>(type: "REAL", nullable: false),
                    Samurai = table.Column<float>(type: "REAL", nullable: false),
                    School = table.Column<float>(type: "REAL", nullable: false),
                    Showbiz = table.Column<float>(type: "REAL", nullable: false),
                    Space = table.Column<float>(type: "REAL", nullable: false),
                    StrategyGame = table.Column<float>(type: "REAL", nullable: false),
                    SuperPower = table.Column<float>(type: "REAL", nullable: false),
                    Survival = table.Column<float>(type: "REAL", nullable: false),
                    TeamSports = table.Column<float>(type: "REAL", nullable: false),
                    TimeTravel = table.Column<float>(type: "REAL", nullable: false),
                    Vampire = table.Column<float>(type: "REAL", nullable: false),
                    VideoGame = table.Column<float>(type: "REAL", nullable: false),
                    VisualArts = table.Column<float>(type: "REAL", nullable: false),
                    Workplace = table.Column<float>(type: "REAL", nullable: false),
                    Josei = table.Column<float>(type: "REAL", nullable: false),
                    Kids = table.Column<float>(type: "REAL", nullable: false),
                    Seinen = table.Column<float>(type: "REAL", nullable: false),
                    Shoujo = table.Column<float>(type: "REAL", nullable: false),
                    Shounen = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserScorings",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserScore = table.Column<float>(type: "REAL", nullable: false),
                    Action = table.Column<float>(type: "REAL", nullable: false),
                    Adventure = table.Column<float>(type: "REAL", nullable: false),
                    AvantGarde = table.Column<float>(type: "REAL", nullable: false),
                    AwardWinning = table.Column<float>(type: "REAL", nullable: false),
                    BoysLove = table.Column<float>(type: "REAL", nullable: false),
                    Comedy = table.Column<float>(type: "REAL", nullable: false),
                    Drama = table.Column<float>(type: "REAL", nullable: false),
                    Fantasy = table.Column<float>(type: "REAL", nullable: false),
                    GirlsLove = table.Column<float>(type: "REAL", nullable: false),
                    Gourmet = table.Column<float>(type: "REAL", nullable: false),
                    Horror = table.Column<float>(type: "REAL", nullable: false),
                    Mystery = table.Column<float>(type: "REAL", nullable: false),
                    Romance = table.Column<float>(type: "REAL", nullable: false),
                    SciFi = table.Column<float>(type: "REAL", nullable: false),
                    SliceOfLife = table.Column<float>(type: "REAL", nullable: false),
                    Sports = table.Column<float>(type: "REAL", nullable: false),
                    Supernatural = table.Column<float>(type: "REAL", nullable: false),
                    Suspense = table.Column<float>(type: "REAL", nullable: false),
                    Ecchi = table.Column<float>(type: "REAL", nullable: false),
                    Erotica = table.Column<float>(type: "REAL", nullable: false),
                    Hentai = table.Column<float>(type: "REAL", nullable: false),
                    AdultCast = table.Column<float>(type: "REAL", nullable: false),
                    Anthropomorphic = table.Column<float>(type: "REAL", nullable: false),
                    CGDCT = table.Column<float>(type: "REAL", nullable: false),
                    Childcare = table.Column<float>(type: "REAL", nullable: false),
                    CombatSports = table.Column<float>(type: "REAL", nullable: false),
                    Crossdressing = table.Column<float>(type: "REAL", nullable: false),
                    Delinquents = table.Column<float>(type: "REAL", nullable: false),
                    Detective = table.Column<float>(type: "REAL", nullable: false),
                    Educational = table.Column<float>(type: "REAL", nullable: false),
                    GagHumor = table.Column<float>(type: "REAL", nullable: false),
                    Gore = table.Column<float>(type: "REAL", nullable: false),
                    Harem = table.Column<float>(type: "REAL", nullable: false),
                    HighStakesGame = table.Column<float>(type: "REAL", nullable: false),
                    Historical = table.Column<float>(type: "REAL", nullable: false),
                    IdolsFemale = table.Column<float>(type: "REAL", nullable: false),
                    IdolsMale = table.Column<float>(type: "REAL", nullable: false),
                    Isekai = table.Column<float>(type: "REAL", nullable: false),
                    Iyashikei = table.Column<float>(type: "REAL", nullable: false),
                    LovePolygon = table.Column<float>(type: "REAL", nullable: false),
                    MagicalSexShift = table.Column<float>(type: "REAL", nullable: false),
                    MahouShoujo = table.Column<float>(type: "REAL", nullable: false),
                    MartialArts = table.Column<float>(type: "REAL", nullable: false),
                    Mecha = table.Column<float>(type: "REAL", nullable: false),
                    Medical = table.Column<float>(type: "REAL", nullable: false),
                    Military = table.Column<float>(type: "REAL", nullable: false),
                    Music = table.Column<float>(type: "REAL", nullable: false),
                    Mythology = table.Column<float>(type: "REAL", nullable: false),
                    OrganizedCrime = table.Column<float>(type: "REAL", nullable: false),
                    OtakuCulture = table.Column<float>(type: "REAL", nullable: false),
                    Parody = table.Column<float>(type: "REAL", nullable: false),
                    PerformingArts = table.Column<float>(type: "REAL", nullable: false),
                    Pets = table.Column<float>(type: "REAL", nullable: false),
                    Psychological = table.Column<float>(type: "REAL", nullable: false),
                    Racing = table.Column<float>(type: "REAL", nullable: false),
                    Reincarnation = table.Column<float>(type: "REAL", nullable: false),
                    ReverseHarem = table.Column<float>(type: "REAL", nullable: false),
                    RomanticSubtext = table.Column<float>(type: "REAL", nullable: false),
                    Samurai = table.Column<float>(type: "REAL", nullable: false),
                    School = table.Column<float>(type: "REAL", nullable: false),
                    Showbiz = table.Column<float>(type: "REAL", nullable: false),
                    Space = table.Column<float>(type: "REAL", nullable: false),
                    StrategyGame = table.Column<float>(type: "REAL", nullable: false),
                    SuperPower = table.Column<float>(type: "REAL", nullable: false),
                    Survival = table.Column<float>(type: "REAL", nullable: false),
                    TeamSports = table.Column<float>(type: "REAL", nullable: false),
                    TimeTravel = table.Column<float>(type: "REAL", nullable: false),
                    Vampire = table.Column<float>(type: "REAL", nullable: false),
                    VideoGame = table.Column<float>(type: "REAL", nullable: false),
                    VisualArts = table.Column<float>(type: "REAL", nullable: false),
                    Workplace = table.Column<float>(type: "REAL", nullable: false),
                    Josei = table.Column<float>(type: "REAL", nullable: false),
                    Kids = table.Column<float>(type: "REAL", nullable: false),
                    Seinen = table.Column<float>(type: "REAL", nullable: false),
                    Shoujo = table.Column<float>(type: "REAL", nullable: false),
                    Shounen = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserScorings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSeries",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    Score = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSeries", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animes");

            migrationBuilder.DropTable(
                name: "UserScorings");

            migrationBuilder.DropTable(
                name: "UserSeries");
        }
    }
}
