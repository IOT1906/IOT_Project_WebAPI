using Microsoft.EntityFrameworkCore.Migrations;

namespace IOT_Project_MyDB.Migrations
{
    public partial class V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResourcesRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Applicationdepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Applicationtime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jobtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jobdescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numberofpeopleonhand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numberofrecruits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Professionalrequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jobrequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salarypackage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Probationperiod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reasonforapplication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Annex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourcesRequirements", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResourcesRequirements");
        }
    }
}
