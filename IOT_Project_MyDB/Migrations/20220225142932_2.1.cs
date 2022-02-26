using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IOT_Project_MyDB.Migrations
{
    public partial class _21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Annual_plan",
                columns: table => new
                {
                    Annualid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tabulator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tabulation_Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tabulation_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Particular_year = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annual_plan", x => x.Annualid);
                });

            migrationBuilder.CreateTable(
                name: "Expected_increase_this_year",
                columns: table => new
                {
                    YearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Station = table.Column<int>(type: "int", nullable: false),
                    Last_year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    January = table.Column<int>(type: "int", nullable: false),
                    February = table.Column<int>(type: "int", nullable: false),
                    March = table.Column<int>(type: "int", nullable: false),
                    April = table.Column<int>(type: "int", nullable: false),
                    May = table.Column<int>(type: "int", nullable: false),
                    June = table.Column<int>(type: "int", nullable: false),
                    July = table.Column<int>(type: "int", nullable: false),
                    August = table.Column<int>(type: "int", nullable: false),
                    September = table.Column<int>(type: "int", nullable: false),
                    October = table.Column<int>(type: "int", nullable: false),
                    November = table.Column<int>(type: "int", nullable: false),
                    December = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expected_increase_this_year", x => x.YearId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Annual_plan");

            migrationBuilder.DropTable(
                name: "Expected_increase_this_year");
        }
    }
}
