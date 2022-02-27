using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IOT_Project_MyDB.Migrations
{
    public partial class ac1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "taff_entering",
                columns: table => new
                {
                    sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Taskid = table.Column<int>(type: "int", nullable: false),
                    departmentid = table.Column<int>(type: "int", nullable: false),
                    roleid = table.Column<int>(type: "int", nullable: false),
                    vouchtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    explain = table.Column<int>(type: "int", nullable: false),
                    roletype = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<int>(type: "int", nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    culturedegree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    health = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    speciality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    whether = table.Column<int>(type: "int", nullable: false),
                    treatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contract_deadline = table.Column<int>(type: "int", nullable: false),
                    qualifying_period = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taff_entering", x => x.sid);
                });

            migrationBuilder.CreateTable(
                name: "userkinsfolk",
                columns: table => new
                {
                    uid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Taskid = table.Column<int>(type: "int", nullable: false),
                    kinsfolkname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    relation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kinsfolk_post = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userkinsfolk", x => x.uid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "taff_entering");

            migrationBuilder.DropTable(
                name: "userkinsfolk");
        }
    }
}
