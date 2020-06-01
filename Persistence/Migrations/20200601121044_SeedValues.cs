using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 1, "101" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 2, "102" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 3, "103" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 4, "104" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 5, "105" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
