using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_Project.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProdutoModel",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estoque = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(12,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoModel", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "VendaModel",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Codigo_Produto = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaModel", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_VendaModel_ProdutoModel_Codigo_Produto",
                        column: x => x.Codigo_Produto,
                        principalTable: "ProdutoModel",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendaModel_Codigo_Produto",
                table: "VendaModel",
                column: "Codigo_Produto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaModel");

            migrationBuilder.DropTable(
                name: "ProdutoModel");
        }
    }
}
