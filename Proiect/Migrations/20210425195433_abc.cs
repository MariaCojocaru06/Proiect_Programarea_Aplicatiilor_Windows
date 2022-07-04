using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domenii",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Denumire = table.Column<string>(nullable: true),
                    Descriere = table.Column<string>(nullable: true),
                    nrCarti = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domenii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "carte",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    pret = table.Column<float>(nullable: false),
                    titlu = table.Column<string>(nullable: true),
                    autor = table.Column<string>(nullable: true),
                    an_aparitie = table.Column<DateTime>(nullable: false),
                    livrare = table.Column<int>(nullable: false),
                    editura = table.Column<string>(nullable: true),
                    valoare = table.Column<float>(nullable: false),
                    DomeniuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_carte_Domenii_DomeniuId",
                        column: x => x.DomeniuId,
                        principalTable: "Domenii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_carte_DomeniuId",
                table: "carte",
                column: "DomeniuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carte");

            migrationBuilder.DropTable(
                name: "Domenii");
        }
    }
}
