using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mozi.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ertekeles = table.Column<double>(type: "float", nullable: false),
                    Gyarto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeremId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Szekek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Szam = table.Column<int>(type: "int", nullable: false),
                    Foglalt = table.Column<bool>(type: "bit", nullable: false),
                    TeremId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szekek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Szineszek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kor = table.Column<int>(type: "int", nullable: false),
                    Ertekeles = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szineszek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Termek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    TeremNev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termek", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Filmek",
                columns: new[] { "Id", "Ertekeles", "Gyarto", "Nev", "TeremId" },
                values: new object[,]
                {
                    { 1, 6.0, "ASD", "elso nevu", 1 },
                    { 2, 8.0, "ASDASD", "masodik nevu", 2 }
                });

            migrationBuilder.InsertData(
                table: "Szekek",
                columns: new[] { "Id", "Foglalt", "Szam", "TeremId" },
                values: new object[,]
                {
                    { 1, false, 1, 1 },
                    { 2, false, 2, 1 },
                    { 3, false, 3, 1 },
                    { 4, true, 4, 1 },
                    { 5, true, 5, 1 },
                    { 6, true, 6, 1 },
                    { 7, false, 7, 1 },
                    { 11, false, 1, 2 },
                    { 12, true, 2, 2 },
                    { 13, false, 3, 2 },
                    { 14, true, 4, 2 },
                    { 15, false, 5, 2 },
                    { 16, true, 6, 2 },
                    { 17, false, 7, 2 }
                });

            migrationBuilder.InsertData(
                table: "Szineszek",
                columns: new[] { "Id", "Ertekeles", "FilmId", "Kor", "Nev" },
                values: new object[,]
                {
                    { 1, 9.0, 1, 24, "Szinesz1" },
                    { 2, 4.0, 1, 54, "Szinesz2" },
                    { 3, 1.0, 2, 28, "Szinesz3" }
                });

            migrationBuilder.InsertData(
                table: "Termek",
                columns: new[] { "Id", "FilmId", "TeremNev" },
                values: new object[,]
                {
                    { 1, 1, "elso" },
                    { 2, 2, "masodik" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmek");

            migrationBuilder.DropTable(
                name: "Szekek");

            migrationBuilder.DropTable(
                name: "Szineszek");

            migrationBuilder.DropTable(
                name: "Termek");
        }
    }
}
