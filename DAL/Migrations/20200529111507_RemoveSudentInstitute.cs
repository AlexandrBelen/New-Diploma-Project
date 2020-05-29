using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RemoveSudentInstitute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Faculties_id_faculty",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "institute",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "id_faculty",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Faculties_id_faculty",
                table: "Students",
                column: "id_faculty",
                principalTable: "Faculties",
                principalColumn: "IdFaculty",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Faculties_id_faculty",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "id_faculty",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "institute",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Faculties_id_faculty",
                table: "Students",
                column: "id_faculty",
                principalTable: "Faculties",
                principalColumn: "IdFaculty",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
