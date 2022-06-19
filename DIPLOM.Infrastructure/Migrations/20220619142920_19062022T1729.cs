using Microsoft.EntityFrameworkCore.Migrations;

namespace DIPLOM.Infrastructure.Migrations
{
    public partial class _19062022T1729 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Vacancies",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Vacancies");
        }
    }
}
