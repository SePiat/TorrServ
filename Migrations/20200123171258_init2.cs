using Microsoft.EntityFrameworkCore.Migrations;

namespace TorrServ.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pathDownLoad",
                table: "TorrentMoves",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pathDownLoad",
                table: "TorrentMoves");
        }
    }
}
