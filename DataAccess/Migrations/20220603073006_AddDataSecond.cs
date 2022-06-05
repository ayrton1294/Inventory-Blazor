using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddDataSecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "52a47b16-dd07-4e87-8896-b8ac9bac2982");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "8f9bfe16-ec1e-4173-a361-bc02e7635645");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "b5e56016-df8d-4df9-a3c0-bc5a8b8de733");

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[] { "072d1d80-4b30-4c31-b436-2d971cc66108", "932 Pallet Street, La Grange (Dutchess), NY 12540", "Bodega Principal" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[] { "135f748b-ffda-4f44-9331-d3e87494ee0d", "4447 Dane Street, Yakima, WA 98908", "Bodega Secundaria" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[] { "a1557e34-4ac0-42fd-8510-89f151965b1a", "3003 Arrowood Drive, Jacksonville, FL 32257", "Bogeda Terciaria" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "072d1d80-4b30-4c31-b436-2d971cc66108");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "135f748b-ffda-4f44-9331-d3e87494ee0d");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "a1557e34-4ac0-42fd-8510-89f151965b1a");

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[] { "52a47b16-dd07-4e87-8896-b8ac9bac2982", "932 Pallet Street, La Grange (Dutchess), NY 12540", "Main WareHouse" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[] { "8f9bfe16-ec1e-4173-a361-bc02e7635645", "4447 Dane Street, Yakima, WA 98908", "Second WareHouse" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[] { "b5e56016-df8d-4df9-a3c0-bc5a8b8de733", "3003 Arrowood Drive, Jacksonville, FL 32257", "Third WareHouse" });
        }
    }
}
