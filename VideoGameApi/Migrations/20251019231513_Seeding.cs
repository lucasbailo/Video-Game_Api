using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Developer", "Plataform", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Nintendo EPD", "Nintendo Switch", "Nintendo", "The Legend of Zelda: Breath of the Wild" },
                    { 2, "Santa Monica Studio", "PlayStation 5", "Sony Interactive Entertainment", "God of War: Ragnarök" },
                    { 3, "FromSoftware", "PC", "Bandai Namco Entertainment", "Elden Ring" },
                    { 4, "Rockstar Games", "Xbox One", "Rockstar Games", "Red Dead Redemption 2" },
                    { 5, "Nintendo EPD", "Nintendo Switch", "Nintendo", "Super Mario Odyssey" },
                    { 6, "343 Industries", "Xbox Series X/S", "Xbox Game Studios", "Halo Infinite" },
                    { 7, "Insomniac Games", "PlayStation 5", "Sony Interactive Entertainment", "Spider-Man 2" },
                    { 8, "CD Projekt Red", "PC", "CD Projekt", "The Witcher 3: Wild Hunt" },
                    { 9, "Mojang Studios", "Multi-platform", "Microsoft Studios", "Minecraft" },
                    { 10, "Epic Games", "Multi-platform", "Epic Games", "Fortnite" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
