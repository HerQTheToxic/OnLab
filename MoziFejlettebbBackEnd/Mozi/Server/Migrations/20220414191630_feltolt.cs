using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mozi.Server.Migrations
{
    public partial class feltolt : Migration
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
                    Gyarto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmek", x => x.Id);
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
                    table.ForeignKey(
                        name: "FK_Szineszek_Filmek_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Filmek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Termek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeremNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Termek_Filmek_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Filmek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Szekek_Termek_TeremId",
                        column: x => x.TeremId,
                        principalTable: "Termek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Filmek",
                columns: new[] { "Id", "Ertekeles", "Gyarto", "Nev" },
                values: new object[] { 1, 6.0, "Lászlo és a fia", "Elso film" });

            migrationBuilder.InsertData(
                table: "Filmek",
                columns: new[] { "Id", "Ertekeles", "Gyarto", "Nev" },
                values: new object[] { 2, 8.0, "Profi gyártó", "Masodik film" });

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
                    { 1, 1, "Elso" },
                    { 2, 2, "Masodik" },
                    { 3, 2, "Harmadik" }
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
                    { 8, false, 8, 1 },
                    { 9, false, 9, 1 },
                    { 10, false, 10, 1 },
                    { 11, false, 11, 1 },
                    { 12, false, 12, 1 },
                    { 13, false, 13, 1 },
                    { 14, true, 14, 1 },
                    { 15, true, 15, 1 },
                    { 16, true, 16, 1 },
                    { 17, false, 17, 1 },
                    { 18, false, 18, 1 },
                    { 19, false, 19, 1 },
                    { 20, false, 20, 1 },
                    { 21, false, 1, 2 },
                    { 22, false, 2, 2 },
                    { 23, false, 3, 2 },
                    { 24, true, 4, 2 },
                    { 25, true, 5, 2 },
                    { 26, true, 6, 2 },
                    { 27, false, 7, 2 },
                    { 28, false, 8, 2 },
                    { 29, true, 9, 2 },
                    { 30, false, 10, 2 },
                    { 31, false, 11, 2 },
                    { 32, false, 12, 2 },
                    { 33, false, 13, 2 },
                    { 34, true, 14, 2 },
                    { 35, true, 15, 2 },
                    { 36, true, 16, 2 },
                    { 37, false, 17, 2 },
                    { 38, false, 18, 2 },
                    { 39, true, 19, 2 },
                    { 40, true, 20, 2 },
                    { 41, false, 1, 3 },
                    { 42, false, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Szekek",
                columns: new[] { "Id", "Foglalt", "Szam", "TeremId" },
                values: new object[,]
                {
                    { 43, false, 3, 3 },
                    { 44, true, 4, 3 },
                    { 45, true, 5, 3 },
                    { 46, true, 6, 3 },
                    { 47, false, 7, 3 },
                    { 48, false, 8, 3 },
                    { 49, true, 9, 3 },
                    { 50, false, 10, 3 },
                    { 51, false, 11, 3 },
                    { 52, false, 12, 3 },
                    { 53, false, 13, 3 },
                    { 54, true, 14, 3 },
                    { 55, true, 15, 3 },
                    { 56, true, 16, 3 },
                    { 57, false, 17, 3 },
                    { 58, false, 18, 3 },
                    { 59, true, 19, 3 },
                    { 60, true, 20, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Szekek_TeremId",
                table: "Szekek",
                column: "TeremId");

            migrationBuilder.CreateIndex(
                name: "IX_Szineszek_FilmId",
                table: "Szineszek",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Termek_FilmId",
                table: "Termek",
                column: "FilmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Szekek");

            migrationBuilder.DropTable(
                name: "Szineszek");

            migrationBuilder.DropTable(
                name: "Termek");

            migrationBuilder.DropTable(
                name: "Filmek");
        }
    }
}
