using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Projeto_MVC.Migrations
{
    public partial class ModificacoesModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Pessoa_Pessoaid",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_Pessoaid",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Pessoaid",
                table: "Endereco");

            migrationBuilder.AddColumn<Guid>(
                name: "Endereco_Id",
                table: "Pessoa",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_Endereco_Id",
                table: "Pessoa",
                column: "Endereco_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Endereco_Endereco_Id",
                table: "Pessoa",
                column: "Endereco_Id",
                principalTable: "Endereco",
                principalColumn: "Endereco_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Endereco_Endereco_Id",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_Endereco_Id",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Endereco_Id",
                table: "Pessoa");

            migrationBuilder.AddColumn<Guid>(
                name: "Pessoaid",
                table: "Endereco",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Pessoaid",
                table: "Endereco",
                column: "Pessoaid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Pessoa_Pessoaid",
                table: "Endereco",
                column: "Pessoaid",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
