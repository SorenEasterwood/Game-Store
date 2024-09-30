using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_Store.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Cost", "Rating", "Title", "Year" },
                values: new object[,]
                {
                    { 1, 49.990000000000002, 9, "Final Fantasy XVI", 2023 },
                    { 2, 39.990000000000002, 10, "Red Dead Redemption 2", 2018 },
                    { 3, 59.990000000000002, 10, "Baldurs Gate 3", 2023 },
                    { 4, 19.989999999999998, 9, "God of War (2018)", 2018 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
