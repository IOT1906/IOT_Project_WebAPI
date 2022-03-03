using Microsoft.EntityFrameworkCore.Migrations;

namespace IOT_Project_MyDB.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Engrave_chapter",
                columns: table => new
                {
                    AnnounId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seal_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyProperty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imprint_mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engrave_chapter", x => x.AnnounId);
                });

            migrationBuilder.CreateTable(
                name: "Management",
                columns: table => new
                {
                    ManId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    ManType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mandocuments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mannumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manarchiver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mancontent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manattachment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Management", x => x.ManId);
                });

            migrationBuilder.CreateTable(
                name: "Notice",
                columns: table => new
                {
                    AnnounId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Typing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Release_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notice", x => x.AnnounId);
                });

            migrationBuilder.CreateTable(
                name: "Use_seal",
                columns: table => new
                {
                    AnnounId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Applicant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seal_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lend_out = table.Column<int>(type: "int", nullable: false),
                    Entourage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Return_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Out_of_office_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Printing_matters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Use_seal", x => x.AnnounId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engrave_chapter");

            migrationBuilder.DropTable(
                name: "Management");

            migrationBuilder.DropTable(
                name: "Notice");

            migrationBuilder.DropTable(
                name: "Use_seal");
        }
    }
}
