using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolos2.Migrations
{
    public partial class configure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_zamowienie_WyrobCukierniczies",
                table: "zamowienie_WyrobCukierniczies");

            migrationBuilder.AlterColumn<string>(
                name: "Uwagi",
                table: "zamowienie_WyrobCukierniczies",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdZamowienia",
                table: "zamowienie_WyrobCukierniczies",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "IdWyrobCukierniczy",
                table: "zamowienie_WyrobCukierniczies",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zamowienie_WyrobCukierniczies",
                table: "zamowienie_WyrobCukierniczies",
                column: "IdZamowienia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_zamowienie_WyrobCukierniczies",
                table: "zamowienie_WyrobCukierniczies");

            migrationBuilder.AlterColumn<string>(
                name: "Uwagi",
                table: "zamowienie_WyrobCukierniczies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdWyrobCukierniczy",
                table: "zamowienie_WyrobCukierniczies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "IdZamowienia",
                table: "zamowienie_WyrobCukierniczies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zamowienie_WyrobCukierniczies",
                table: "zamowienie_WyrobCukierniczies",
                column: "IdWyrobCukierniczy");
        }
    }
}
