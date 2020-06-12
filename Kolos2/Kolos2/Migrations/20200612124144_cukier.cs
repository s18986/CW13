using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Kolos2.Migrations
{
    public partial class cukier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pracowniks",
                columns: table => new
                {
                    idPracownik = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracowniks", x => x.idPracownik);
                });

            migrationBuilder.CreateTable(
                name: "WyrobCukierniczies",
                columns: table => new
                {
                    IdWyrobuCukierniczego = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(nullable: true),
                    CenaZaSzt = table.Column<float>(nullable: false),
                    Typ = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WyrobCukierniczies", x => x.IdWyrobuCukierniczego);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienies",
                columns: table => new
                {
                    IdZamowieni = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPrzyjecia = table.Column<DateTime>(nullable: false),
                    DataRealizacji = table.Column<DateTime>(nullable: false),
                    Uwagi = table.Column<string>(nullable: true),
                    IdKlient = table.Column<int>(nullable: false),
                    IdPracownik = table.Column<int>(nullable: false),
                    KlientId = table.Column<int>(nullable: true),
                    PracownikidPracownik = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienies", x => x.IdZamowieni);
                    table.ForeignKey(
                        name: "FK_Zamowienies_Klients_KlientId",
                        column: x => x.KlientId,
                        principalTable: "Klients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zamowienies_Pracowniks_PracownikidPracownik",
                        column: x => x.PracownikidPracownik,
                        principalTable: "Pracowniks",
                        principalColumn: "idPracownik",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienies_KlientId",
                table: "Zamowienies",
                column: "KlientId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienies_PracownikidPracownik",
                table: "Zamowienies",
                column: "PracownikidPracownik");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WyrobCukierniczies");

            migrationBuilder.DropTable(
                name: "Zamowienies");

            migrationBuilder.DropTable(
                name: "Klients");

            migrationBuilder.DropTable(
                name: "Pracowniks");
        }
    }
}
