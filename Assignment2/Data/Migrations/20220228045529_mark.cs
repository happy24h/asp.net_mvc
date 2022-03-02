using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2.Data.Migrations
{
    public partial class mark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mark",
                table: "Test",
                newName: "TheoryMark");

            migrationBuilder.AddColumn<double>(
                name: "AssignmentMark",
                table: "Test",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PracticeMark",
                table: "Test",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignmentMark",
                table: "Test");

            migrationBuilder.DropColumn(
                name: "PracticeMark",
                table: "Test");

            migrationBuilder.RenameColumn(
                name: "TheoryMark",
                table: "Test",
                newName: "Mark");
        }
    }
}
