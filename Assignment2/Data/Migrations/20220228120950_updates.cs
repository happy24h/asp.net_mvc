using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2.Data.Migrations
{
    public partial class updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SemesterId",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SemesterId",
                table: "Semester",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SemesterId",
                table: "Subject",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Semester_SemesterId",
                table: "Semester",
                column: "SemesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Semester_Semester_SemesterId",
                table: "Semester",
                column: "SemesterId",
                principalTable: "Semester",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Semester_SemesterId",
                table: "Subject",
                column: "SemesterId",
                principalTable: "Semester",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Semester_Semester_SemesterId",
                table: "Semester");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Semester_SemesterId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_SemesterId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Semester_SemesterId",
                table: "Semester");

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "Semester");
        }
    }
}
