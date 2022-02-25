using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IOT_Project_MyDB.Migrations
{
    public partial class ljq01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leave",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Proposer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplyDemo = table.Column<int>(type: "int", nullable: false),
                    ApplyTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    LeaveCause = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaveImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaveRemark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leave");
        }
    }
}
