using Microsoft.EntityFrameworkCore.Migrations;

namespace IOT_Project_MyDB.Migrations
{
    public partial class v14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Daily",
                columns: table => new
                {
                    DaiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Daiapplicant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Daiagent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Daidepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaiHandling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaiApplication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Daidate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Daiuse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dainote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daily", x => x.DaiId);
                });

            migrationBuilder.CreateTable(
                name: "Dailydetailed",
                columns: table => new
                {
                    Dailys = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Daisserial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Daisname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Daisspecifications = table.Column<int>(type: "int", nullable: false),
                    Daisnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Daisunit = table.Column<int>(type: "int", nullable: false),
                    Daisprice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Daisnote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dailydetailed", x => x.Dailys);
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    MyPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    MyPName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPseat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPfloor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPaccommodate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPconditioner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPprojector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPwhiteboard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPnetwork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPrange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPdispenser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPadministrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPphotograph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyPnote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.MyPId);
                });

            migrationBuilder.CreateTable(
                name: "ReceItemDetails",
                columns: table => new
                {
                    RecesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    RecesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recespecifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recesuse = table.Column<int>(type: "int", nullable: false),
                    Recesinventory = table.Column<int>(type: "int", nullable: false),
                    Recesremaining = table.Column<int>(type: "int", nullable: false),
                    Recesnote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceItemDetails", x => x.RecesId);
                });

            migrationBuilder.CreateTable(
                name: "ReceItineraryDetails",
                columns: table => new
                {
                    RececId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Rececstart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rececend = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recectrip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RececAccompanied = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receccar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rececmeeting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recechotel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rececexhibition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rececmeal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rececdepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rececnote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceItineraryDetails", x => x.RececId);
                });

            migrationBuilder.CreateTable(
                name: "Receptionbase",
                columns: table => new
                {
                    ReceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Receapplicant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recedepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recetime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recevisitors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recemain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recestay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recethe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receunawares = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receneed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceFlight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receitems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceVisiting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recerequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recenote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receptionbase", x => x.ReceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Daily");

            migrationBuilder.DropTable(
                name: "Dailydetailed");

            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropTable(
                name: "ReceItemDetails");

            migrationBuilder.DropTable(
                name: "ReceItineraryDetails");

            migrationBuilder.DropTable(
                name: "Receptionbase");
        }
    }
}
