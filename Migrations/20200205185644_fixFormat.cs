using Microsoft.EntityFrameworkCore.Migrations;

namespace TorrServ.Data.Migrations
{
    public partial class fixFormat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "earOfIssue",
                table: "TorrentMoves",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "downloads",
                table: "TorrentMoves",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "earOfIssue",
                table: "TorrentMoves",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "downloads",
                table: "TorrentMoves",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
