using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DIPLOM.Infrastructure.Migrations
{
    public partial class _19062022T1410 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Contracts_ContractId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employers_Contracts_ContractId",
                table: "Employers");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Contracts_ContractId",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_Employers_ContractId",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ContractId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ContractId",
                table: "Vacancies",
                newName: "EmployerId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_ContractId",
                table: "Vacancies",
                newName: "IX_Vacancies_EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CustomerId",
                table: "Contracts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_EmployerId",
                table: "Contracts",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_VacancyId",
                table: "Contracts",
                column: "VacancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Customers_CustomerId",
                table: "Contracts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Employers_EmployerId",
                table: "Contracts",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Vacancies_VacancyId",
                table: "Contracts",
                column: "VacancyId",
                principalTable: "Vacancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Employers_EmployerId",
                table: "Vacancies",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Customers_CustomerId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Employers_EmployerId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Vacancies_VacancyId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Employers_EmployerId",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_CustomerId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_EmployerId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_VacancyId",
                table: "Contracts");

            migrationBuilder.RenameColumn(
                name: "EmployerId",
                table: "Vacancies",
                newName: "ContractId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_EmployerId",
                table: "Vacancies",
                newName: "IX_Vacancies_ContractId");

            migrationBuilder.AddColumn<Guid>(
                name: "ContractId",
                table: "Employers",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ContractId",
                table: "Customers",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employers_ContractId",
                table: "Employers",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ContractId",
                table: "Customers",
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
    }
}
