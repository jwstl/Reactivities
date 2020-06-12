using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ActivityEntityAddedTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Activities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Activities");

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 1, "Value 101" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 2, "Value 102" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 3, "Value 103" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 4, "Value 104" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "id", "Name" },
                values: new object[] { 5, "Value 105" });
        }
    }
}
