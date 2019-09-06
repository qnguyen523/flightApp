using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace flightApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "flight",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    departure = table.Column<string>(nullable: true),
                    destination = table.Column<string>(nullable: true),
                    departureTime = table.Column<DateTime>(nullable: false),
                    arrivalTime = table.Column<DateTime>(nullable: false),
                    Class = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flight", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "flight");
        }
    }
}
