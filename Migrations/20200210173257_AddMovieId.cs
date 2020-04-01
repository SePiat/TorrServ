using Microsoft.EntityFrameworkCore.Migrations;

namespace TorrServ.Data.Migrations
{
    public partial class AddMovieId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "movieId",
                table: "TorrentMoves",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "movieId",
                table: "TorrentMoves");
        }
    }
}
