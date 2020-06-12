using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolos2.Migrations
{
    public partial class full_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "zamowienie_WyrobCukierniczies",
                columns: table => new
                {
                    IdWyrobCukierniczy = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdZamowienia = table.Column<int>(nullable: false),
                    Ilosc = table.Column<int>(nullable: false),
                    Uwagi = table.Column<string>(nullable: true),
                    WyrobCukierniczyIdWyrobuCukierniczego = table.Column<int>(nullable: true),
                    ZamowienieIdZamowieni = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zamowienie_WyrobCukierniczies", x => x.IdWyrobCukierniczy);
                    table.ForeignKey(
                        name: "FK_zamowienie_WyrobCukierniczies_WyrobCukierniczies_WyrobCukierniczyIdWyrobuCukierniczego",
                        column: x => x.WyrobCukierniczyIdWyrobuCukierniczego,
                        principalTable: "WyrobCukierniczies",
                        principalColumn: "IdWyrobuCukierniczego",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_zamowienie_WyrobCukierniczies_Zamowienies_ZamowienieIdZamowieni",
                        column: x => x.ZamowienieIdZamowieni,
                        principalTable: "Zamowienies",
                        principalColumn: "IdZamowieni",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_WyrobCukierniczies_WyrobCukierniczyIdWyrobuCukierniczego",
                table: "zamowienie_WyrobCukierniczies",
                column: "WyrobCukierniczyIdWyrobuCukierniczego");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_WyrobCukierniczies_ZamowienieIdZamowieni",
                table: "zamowienie_WyrobCukierniczies",
                column: "ZamowienieIdZamowieni");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "zamowienie_WyrobCukierniczies");
        }
    }
}
