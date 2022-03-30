using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_locations.Migrations
{
    public partial class NewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 1, "+45", "Danska", "Denmark" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 2, "+34", "Španjolska", "Spian" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "id", "city_name", "country_id", "latitude", "longitude" },
                values: new object[,]
                {
                    { 1, "Kopenhagen", 1, 55.672520m, 12.563413m },
                    { 2, "Holstebro", 1, 56.362564m, 8.621231m },
                    { 3, "Kolding", 1, 55.495972m, 9.473052m },
                    { 4, "Madrid", 2, 40.416775m, -3.703790m },
                    { 5, "Barcelona", 2, 41.346176m, 2.168365m },
                    { 6, "Sevilla", 2, 37.392529m, -5.994072m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
