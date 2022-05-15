using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MLRecommendator.Database.Migrations
{
    public partial class InitialCreate : Migration
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
                    Mean = table.Column<double>(type: "REAL", nullable: false),
                    Rank = table.Column<uint>(type: "INTEGER", nullable: false),
                    Popularity = table.Column<uint>(type: "INTEGER", nullable: false),
                    UsersNumber = table.Column<uint>(type: "INTEGER", nullable: false),
                    UsersScoringNumber = table.Column<uint>(type: "INTEGER", nullable: false),
                    Nsfw = table.Column<string>(type: "TEXT", nullable: true),
                    Genres = table.Column<string>(type: "TEXT", nullable: true),
                    EpisodeNumber = table.Column<ushort>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Studios = table.Column<string>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    AverageEpisodeDuration = table.Column<ushort>(type: "INTEGER", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: true)
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
