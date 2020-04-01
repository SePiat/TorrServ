using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorrServ.Data.Migrations
{
    public partial class AddComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    movieIdId = table.Column<Guid>(nullable: true),
                    commentIndex = table.Column<int>(nullable: false),
                    commentText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_TorrentMoves_movieIdId",
                        column: x => x.movieIdId,
                        principalTable: "TorrentMoves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_movieIdId",
                table: "Comments",
                column: "movieIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
