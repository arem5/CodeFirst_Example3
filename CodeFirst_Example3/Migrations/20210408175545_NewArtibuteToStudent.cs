using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst_Example3.Migrations
{
    public partial class NewArtibuteToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "GradeAvg",
                table: "Students",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<short>(
                name: "NumberOfClass",
                table: "Students",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GradeAvg",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "NumberOfClass",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Students");
        }
    }
}
