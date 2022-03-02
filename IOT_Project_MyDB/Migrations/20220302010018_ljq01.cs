using Microsoft.EntityFrameworkCore.Migrations;

namespace IOT_Project_MyDB.Migrations
{
    public partial class ljq01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carapply",
                columns: table => new
                {
                    CarapplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarapplyTaskId = table.Column<int>(type: "int", nullable: false),
                    CarapplyProposer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyTProposerDemp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyProposerDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyWeek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyDepart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyTarget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyStartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyEndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyRiding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyCommon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyPlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyDeparture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyApproach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyKilometre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyFinish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyPractical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyDriver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarapplyRemark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carapply", x => x.CarapplyId);
                });

            migrationBuilder.CreateTable(
                name: "HandOver",
                columns: table => new
                {
                    HId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    HandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandDemp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Handdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Handpostion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandProve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandImgurl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandHeir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandDempContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandDempCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandFinceContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandFinceCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandStativeContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandStativeCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HandRemark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandOver", x => x.HId);
                });

            migrationBuilder.CreateTable(
                name: "Interview",
                columns: table => new
                {
                    TnterviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    InterviewLister = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewListerDemp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewListerDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewStaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewStaffNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewStaion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewStarDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewEndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewLabor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewCase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewLeaving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewRecord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewPay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewTrain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewProspect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewAward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewChnnel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewSatisfaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewManage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewEmploy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterviewRemark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interview", x => x.TnterviewId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carapply");

            migrationBuilder.DropTable(
                name: "HandOver");

            migrationBuilder.DropTable(
                name: "Interview");
        }
    }
}
