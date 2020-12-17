using Microsoft.EntityFrameworkCore.Migrations;

namespace LoggingSQLTest.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Witcher: Wild Hunt" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Cyberpunk 2077" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Doom" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "GameId", "Text" },
                values: new object[,]
                {
                    { 1, 1, "RPG" },
                    { 2, 1, "Fantasy" },
                    { 3, 1, "Action" },
                    { 4, 2, "RPG" },
                    { 5, 2, "Cyberpunk" },
                    { 6, 2, "Action" },
                    { 7, 3, "Shooter" },
                    { 8, 3, "Action" },
                    { 9, 3, "Sci-fi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_GameId",
                table: "Tags",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
