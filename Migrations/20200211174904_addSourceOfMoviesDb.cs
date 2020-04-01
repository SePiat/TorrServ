using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorrServ.Data.Migrations
{
    public partial class addSourceOfMoviesDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SourceOfMovies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceOfMovies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SourceOfMovies");
        }
    }
}
