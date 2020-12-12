using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagment.Data.Migrations
{
    public partial class IsActiveColumnAddedToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b18dc376-7eb1-445b-82e6-4aa9c8b46ffd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "61975b6f-493f-420c-979d-ba2cd3329251");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3c0d0c7-f03c-4cbf-a678-299cef312a08", true, "AQAAAAEAACcQAAAAELjcpmShcgQkw5L2Xu6yJrue4CLnEaNO+27D9ESlmJFAV+uVm5injCPChhVOes2WsQ==", "8484b8b4-8d64-404f-b4af-4d956c24497a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

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
    }
}
