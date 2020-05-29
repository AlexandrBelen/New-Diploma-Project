using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Add_Gruppa_EducationalDegree_ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Gruppas_educLevel",
                table: "Gruppas",
                column: "educLevel");

            migrationBuilder.AddForeignKey(
                name: "FK_Gruppas_EducationalDegrees_educLevel",
                table: "Gruppas",
                column: "educLevel",
                principalTable: "EducationalDegrees",
                principalColumn: "IdDegree",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gruppas_EducationalDegrees_educLevel",
                table: "Gruppas");

            migrationBuilder.DropIndex(
                name: "IX_Gruppas_educLevel",
                table: "Gruppas");
        }
    }
}
