using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    SeriesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Mean = table.Column<float>(type: "real", nullable: false),
                    Rank = table.Column<long>(type: "bigint", nullable: false),
                    Popularity = table.Column<long>(type: "bigint", nullable: false),
                    UsersNumber = table.Column<long>(type: "bigint", nullable: false),
                    UsersScoringNumber = table.Column<long>(type: "bigint", nullable: false),
                    Nsfw = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Synopsis = table.Column<string>(type: "text", nullable: true),
                    Genres = table.Column<string>(type: "text", nullable: true),
                    EpisodeNumber = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Studios = table.Column<string>(type: "text", nullable: true),
                    Source = table.Column<string>(type: "text", nullable: true),
                    AverageEpisodeDuration = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<string>(type: "text", nullable: true),
                    Action = table.Column<float>(type: "real", nullable: false),
                    Adventure = table.Column<float>(type: "real", nullable: false),
                    AvantGarde = table.Column<float>(type: "real", nullable: false),
                    AwardWinning = table.Column<float>(type: "real", nullable: false),
                    BoysLove = table.Column<float>(type: "real", nullable: false),
                    Comedy = table.Column<float>(type: "real", nullable: false),
                    Drama = table.Column<float>(type: "real", nullable: false),
                    Fantasy = table.Column<float>(type: "real", nullable: false),
                    GirlsLove = table.Column<float>(type: "real", nullable: false),
                    Gourmet = table.Column<float>(type: "real", nullable: false),
                    Horror = table.Column<float>(type: "real", nullable: false),
                    Mystery = table.Column<float>(type: "real", nullable: false),
                    Romance = table.Column<float>(type: "real", nullable: false),
                    SciFi = table.Column<float>(type: "real", nullable: false),
                    SliceOfLife = table.Column<float>(type: "real", nullable: false),
                    Sports = table.Column<float>(type: "real", nullable: false),
                    Supernatural = table.Column<float>(type: "real", nullable: false),
                    Suspense = table.Column<float>(type: "real", nullable: false),
                    Ecchi = table.Column<float>(type: "real", nullable: false),
                    Erotica = table.Column<float>(type: "real", nullable: false),
                    Hentai = table.Column<float>(type: "real", nullable: false),
                    AdultCast = table.Column<float>(type: "real", nullable: false),
                    Anthropomorphic = table.Column<float>(type: "real", nullable: false),
                    CGDCT = table.Column<float>(type: "real", nullable: false),
                    Childcare = table.Column<float>(type: "real", nullable: false),
                    CombatSports = table.Column<float>(type: "real", nullable: false),
                    Crossdressing = table.Column<float>(type: "real", nullable: false),
                    Delinquents = table.Column<float>(type: "real", nullable: false),
                    Detective = table.Column<float>(type: "real", nullable: false),
                    Educational = table.Column<float>(type: "real", nullable: false),
                    GagHumor = table.Column<float>(type: "real", nullable: false),
                    Gore = table.Column<float>(type: "real", nullable: false),
                    Harem = table.Column<float>(type: "real", nullable: false),
                    HighStakesGame = table.Column<float>(type: "real", nullable: false),
                    Historical = table.Column<float>(type: "real", nullable: false),
                    IdolsFemale = table.Column<float>(type: "real", nullable: false),
                    IdolsMale = table.Column<float>(type: "real", nullable: false),
                    Isekai = table.Column<float>(type: "real", nullable: false),
                    Iyashikei = table.Column<float>(type: "real", nullable: false),
                    LovePolygon = table.Column<float>(type: "real", nullable: false),
                    MagicalSexShift = table.Column<float>(type: "real", nullable: false),
                    MahouShoujo = table.Column<float>(type: "real", nullable: false),
                    MartialArts = table.Column<float>(type: "real", nullable: false),
                    Mecha = table.Column<float>(type: "real", nullable: false),
                    Medical = table.Column<float>(type: "real", nullable: false),
                    Military = table.Column<float>(type: "real", nullable: false),
                    Music = table.Column<float>(type: "real", nullable: false),
                    Mythology = table.Column<float>(type: "real", nullable: false),
                    OrganizedCrime = table.Column<float>(type: "real", nullable: false),
                    OtakuCulture = table.Column<float>(type: "real", nullable: false),
                    Parody = table.Column<float>(type: "real", nullable: false),
                    PerformingArts = table.Column<float>(type: "real", nullable: false),
                    Pets = table.Column<float>(type: "real", nullable: false),
                    Psychological = table.Column<float>(type: "real", nullable: false),
                    Racing = table.Column<float>(type: "real", nullable: false),
                    Reincarnation = table.Column<float>(type: "real", nullable: false),
                    ReverseHarem = table.Column<float>(type: "real", nullable: false),
                    RomanticSubtext = table.Column<float>(type: "real", nullable: false),
                    Samurai = table.Column<float>(type: "real", nullable: false),
                    School = table.Column<float>(type: "real", nullable: false),
                    Showbiz = table.Column<float>(type: "real", nullable: false),
                    Space = table.Column<float>(type: "real", nullable: false),
                    StrategyGame = table.Column<float>(type: "real", nullable: false),
                    SuperPower = table.Column<float>(type: "real", nullable: false),
                    Survival = table.Column<float>(type: "real", nullable: false),
                    TeamSports = table.Column<float>(type: "real", nullable: false),
                    TimeTravel = table.Column<float>(type: "real", nullable: false),
                    Vampire = table.Column<float>(type: "real", nullable: false),
                    VideoGame = table.Column<float>(type: "real", nullable: false),
                    VisualArts = table.Column<float>(type: "real", nullable: false),
                    Workplace = table.Column<float>(type: "real", nullable: false),
                    Josei = table.Column<float>(type: "real", nullable: false),
                    Kids = table.Column<float>(type: "real", nullable: false),
                    Seinen = table.Column<float>(type: "real", nullable: false),
                    Shoujo = table.Column<float>(type: "real", nullable: false),
                    Shounen = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.SeriesId);
                });

            migrationBuilder.CreateTable(
                name: "UserScorings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    UserScore = table.Column<float>(type: "real", nullable: false),
                    Action = table.Column<float>(type: "real", nullable: false),
                    Adventure = table.Column<float>(type: "real", nullable: false),
                    AvantGarde = table.Column<float>(type: "real", nullable: false),
                    AwardWinning = table.Column<float>(type: "real", nullable: false),
                    BoysLove = table.Column<float>(type: "real", nullable: false),
                    Comedy = table.Column<float>(type: "real", nullable: false),
                    Drama = table.Column<float>(type: "real", nullable: false),
                    Fantasy = table.Column<float>(type: "real", nullable: false),
                    GirlsLove = table.Column<float>(type: "real", nullable: false),
                    Gourmet = table.Column<float>(type: "real", nullable: false),
                    Horror = table.Column<float>(type: "real", nullable: false),
                    Mystery = table.Column<float>(type: "real", nullable: false),
                    Romance = table.Column<float>(type: "real", nullable: false),
                    SciFi = table.Column<float>(type: "real", nullable: false),
                    SliceOfLife = table.Column<float>(type: "real", nullable: false),
                    Sports = table.Column<float>(type: "real", nullable: false),
                    Supernatural = table.Column<float>(type: "real", nullable: false),
                    Suspense = table.Column<float>(type: "real", nullable: false),
                    Ecchi = table.Column<float>(type: "real", nullable: false),
                    Erotica = table.Column<float>(type: "real", nullable: false),
                    Hentai = table.Column<float>(type: "real", nullable: false),
                    AdultCast = table.Column<float>(type: "real", nullable: false),
                    Anthropomorphic = table.Column<float>(type: "real", nullable: false),
                    CGDCT = table.Column<float>(type: "real", nullable: false),
                    Childcare = table.Column<float>(type: "real", nullable: false),
                    CombatSports = table.Column<float>(type: "real", nullable: false),
                    Crossdressing = table.Column<float>(type: "real", nullable: false),
                    Delinquents = table.Column<float>(type: "real", nullable: false),
                    Detective = table.Column<float>(type: "real", nullable: false),
                    Educational = table.Column<float>(type: "real", nullable: false),
                    GagHumor = table.Column<float>(type: "real", nullable: false),
                    Gore = table.Column<float>(type: "real", nullable: false),
                    Harem = table.Column<float>(type: "real", nullable: false),
                    HighStakesGame = table.Column<float>(type: "real", nullable: false),
                    Historical = table.Column<float>(type: "real", nullable: false),
                    IdolsFemale = table.Column<float>(type: "real", nullable: false),
                    IdolsMale = table.Column<float>(type: "real", nullable: false),
                    Isekai = table.Column<float>(type: "real", nullable: false),
                    Iyashikei = table.Column<float>(type: "real", nullable: false),
                    LovePolygon = table.Column<float>(type: "real", nullable: false),
                    MagicalSexShift = table.Column<float>(type: "real", nullable: false),
                    MahouShoujo = table.Column<float>(type: "real", nullable: false),
                    MartialArts = table.Column<float>(type: "real", nullable: false),
                    Mecha = table.Column<float>(type: "real", nullable: false),
                    Medical = table.Column<float>(type: "real", nullable: false),
                    Military = table.Column<float>(type: "real", nullable: false),
                    Music = table.Column<float>(type: "real", nullable: false),
                    Mythology = table.Column<float>(type: "real", nullable: false),
                    OrganizedCrime = table.Column<float>(type: "real", nullable: false),
                    OtakuCulture = table.Column<float>(type: "real", nullable: false),
                    Parody = table.Column<float>(type: "real", nullable: false),
                    PerformingArts = table.Column<float>(type: "real", nullable: false),
                    Pets = table.Column<float>(type: "real", nullable: false),
                    Psychological = table.Column<float>(type: "real", nullable: false),
                    Racing = table.Column<float>(type: "real", nullable: false),
                    Reincarnation = table.Column<float>(type: "real", nullable: false),
                    ReverseHarem = table.Column<float>(type: "real", nullable: false),
                    RomanticSubtext = table.Column<float>(type: "real", nullable: false),
                    Samurai = table.Column<float>(type: "real", nullable: false),
                    School = table.Column<float>(type: "real", nullable: false),
                    Showbiz = table.Column<float>(type: "real", nullable: false),
                    Space = table.Column<float>(type: "real", nullable: false),
                    StrategyGame = table.Column<float>(type: "real", nullable: false),
                    SuperPower = table.Column<float>(type: "real", nullable: false),
                    Survival = table.Column<float>(type: "real", nullable: false),
                    TeamSports = table.Column<float>(type: "real", nullable: false),
                    TimeTravel = table.Column<float>(type: "real", nullable: false),
                    Vampire = table.Column<float>(type: "real", nullable: false),
                    VideoGame = table.Column<float>(type: "real", nullable: false),
                    VisualArts = table.Column<float>(type: "real", nullable: false),
                    Workplace = table.Column<float>(type: "real", nullable: false),
                    Josei = table.Column<float>(type: "real", nullable: false),
                    Kids = table.Column<float>(type: "real", nullable: false),
                    Seinen = table.Column<float>(type: "real", nullable: false),
                    Shoujo = table.Column<float>(type: "real", nullable: false),
                    Shounen = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserScorings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    Score = table.Column<byte>(type: "smallint", nullable: false)
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
