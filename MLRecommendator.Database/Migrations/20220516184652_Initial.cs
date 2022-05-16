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
                    Genres = table.Column<string>(type: "TEXT", nullable: true),
                    EpisodeNumber = table.Column<ushort>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Studios = table.Column<string>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    AverageEpisodeDuration = table.Column<ushort>(type: "INTEGER", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: true),
                    Action = table.Column<float>(type: "REAL", nullable: false),
                    Adventure = table.Column<float>(type: "REAL", nullable: false),
                    AdultCast = table.Column<float>(type: "REAL", nullable: false),
                    SciFi = table.Column<float>(type: "REAL", nullable: false),
                    Space = table.Column<float>(type: "REAL", nullable: false),
                    Comedy = table.Column<float>(type: "REAL", nullable: false),
                    Drama = table.Column<float>(type: "REAL", nullable: false),
                    Shounen = table.Column<float>(type: "REAL", nullable: false),
                    Mystery = table.Column<float>(type: "REAL", nullable: false),
                    Psychological = table.Column<float>(type: "REAL", nullable: false),
                    Seinen = table.Column<float>(type: "REAL", nullable: false),
                    Fantasy = table.Column<float>(type: "REAL", nullable: false),
                    Romance = table.Column<float>(type: "REAL", nullable: false),
                    Military = table.Column<float>(type: "REAL", nullable: false),
                    Ecchi = table.Column<float>(type: "REAL", nullable: false),
                    SliceOfLife = table.Column<float>(type: "REAL", nullable: false),
                    School = table.Column<float>(type: "REAL", nullable: false),
                    Historical = table.Column<float>(type: "REAL", nullable: false),
                    Isekai = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSeries",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Score = table.Column<byte>(type: "INTEGER", nullable: false),
                    WatchedEpisodesNumber = table.Column<ushort>(type: "INTEGER", nullable: false),
                    IsRewatching = table.Column<bool>(type: "INTEGER", nullable: false)
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
                name: "UserSeries");
        }
    }
}
