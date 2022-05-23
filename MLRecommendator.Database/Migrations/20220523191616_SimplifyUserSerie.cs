using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MLRecommendator.Database.Migrations
{
    public partial class SimplifyUserSerie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRewatching",
                table: "UserSeries");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserSeries");

            migrationBuilder.DropColumn(
                name: "WatchedEpisodesNumber",
                table: "UserSeries");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "UserSeries",
                newName: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserSeries",
                newName: "Title");

            migrationBuilder.AddColumn<bool>(
                name: "IsRewatching",
                table: "UserSeries",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "UserSeries",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<ushort>(
                name: "WatchedEpisodesNumber",
                table: "UserSeries",
                type: "INTEGER",
                nullable: false,
                defaultValue: (ushort)0);
        }
    }
}
