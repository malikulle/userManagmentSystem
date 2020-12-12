using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagment.Data.Migrations
{
    public partial class ImageUrlAddedToWorkOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "WorkOrders",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9e7f6605-fc25-4b9b-b16f-89ea26838fa3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "348338f3-9175-4c94-9544-2853489254cf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97fc5d87-08f3-457b-bedc-d6d46e0618f0", "AQAAAAEAACcQAAAAEEOeyPHfGjW9yBqsbEribOIHsjyiuKfGzewUUM1BZxx8Be0l2GYcq2ewSynDr9WIew==", "1e29860c-e030-4144-88e4-f2a2f35696de" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "WorkOrders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8baf8e52-834c-4158-9c8b-937682243ba0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "acf01ed7-2e0a-486b-94f6-c807fbfaed5c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a27cab3-b980-40f4-b2e3-b078936bd076", "AQAAAAEAACcQAAAAEHXSDjLiGiPNauGXZMdC4YujQU7F61ura0WolxuUbN7BGyb7c/m4ybW1mu2TlQn7bQ==", "a9f1591d-1c1f-4976-80c1-93c5e7b85244" });
        }
    }
}
