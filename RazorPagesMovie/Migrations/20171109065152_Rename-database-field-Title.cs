using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RazorPagesMovie.Migrations
{
    public partial class RenamedatabasefieldTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tittle",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "Tittle",
                table: "Movie",
                nullable: true);
        }
    }
}
