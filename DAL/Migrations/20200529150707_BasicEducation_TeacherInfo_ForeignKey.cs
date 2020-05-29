using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class BasicEducation_TeacherInfo_ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherInfoes_BasicEducations_id_basicEducation",
                table: "TeacherInfoes");

            migrationBuilder.DropIndex(
                name: "IX_TeacherInfoes_id_basicEducation",
                table: "TeacherInfoes");

            migrationBuilder.DropColumn(
                name: "id_basicEducation",
                table: "TeacherInfoes");

            migrationBuilder.AddColumn<int>(
                name: "id_teacherInfo",
                table: "BasicEducations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BasicEducations_id_teacherInfo",
                table: "BasicEducations",
                column: "id_teacherInfo");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicEducations_TeacherInfoes_id_teacherInfo",
                table: "BasicEducations",
                column: "id_teacherInfo",
                principalTable: "TeacherInfoes",
                principalColumn: "teacherInfoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicEducations_TeacherInfoes_id_teacherInfo",
                table: "BasicEducations");

            migrationBuilder.DropIndex(
                name: "IX_BasicEducations_id_teacherInfo",
                table: "BasicEducations");

            migrationBuilder.DropColumn(
                name: "id_teacherInfo",
                table: "BasicEducations");

            migrationBuilder.AddColumn<int>(
                name: "id_basicEducation",
                table: "TeacherInfoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInfoes_id_basicEducation",
                table: "TeacherInfoes",
                column: "id_basicEducation");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherInfoes_BasicEducations_id_basicEducation",
                table: "TeacherInfoes",
                column: "id_basicEducation",
                principalTable: "BasicEducations",
                principalColumn: "IdBasicEducation",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
