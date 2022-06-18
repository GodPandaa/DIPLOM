using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DIPLOM.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    Lastname = table.Column<string>(type: "text", nullable: true),
                    Profession = table.Column<string>(type: "text", nullable: true),
                    Salary = table.Column<int>(type: "integer", nullable: false),
                    Education = table.Column<string>(type: "text", nullable: true),
                    ContractId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Company = table.Column<string>(type: "text", nullable: true),
                    ContractId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Wages = table.Column<int>(type: "integer", nullable: false),
                    Post = table.Column<string>(type: "text", nullable: true),
                    ContractId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Contract_percentage = table.Column<int>(type: "integer", nullable: false),
                    VacancyIdId = table.Column<Guid>(type: "uuid", nullable: true),
                    EmployerIdId = table.Column<Guid>(type: "uuid", nullable: true),
                    CustomerIdId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Customers_CustomerIdId",
                        column: x => x.CustomerIdId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_Employers_EmployerIdId",
                        column: x => x.EmployerIdId,
                        principalTable: "Employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_Vacancies_VacancyIdId",
                        column: x => x.VacancyIdId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CustomerIdId",
                table: "Contracts",
                column: "CustomerIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_EmployerIdId",
                table: "Contracts",
                column: "EmployerIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_VacancyIdId",
                table: "Contracts",
                column: "VacancyIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ContractId",
                table: "Customers",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_ContractId",
                table: "Employers",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_ContractId",
                table: "Vacancies",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Contracts_ContractId",
                table: "Customers",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_Contracts_ContractId",
                table: "Employers",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Contracts_ContractId",
                table: "Vacancies",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Customers_CustomerIdId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Employers_EmployerIdId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Vacancies_VacancyIdId",
                table: "Contracts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropTable(
                name: "Contracts");
        }
    }
}
