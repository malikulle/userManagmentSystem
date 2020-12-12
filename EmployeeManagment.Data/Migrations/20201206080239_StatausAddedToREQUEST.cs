using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagment.Data.Migrations
{
    public partial class StatausAddedToREQUEST : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "UserLeaveRequests");

            migrationBuilder.DropColumn(
                name: "Cancelled",
                table: "UserLeaveRequests");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "UserLeaveRequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e2bd6a92-4f7f-45b9-be06-a2821c937704");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e0ff1bee-99a7-4088-b116-446a959bb4d1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a72def00-8ce7-4a29-81dc-04e356bd8779", "AQAAAAEAACcQAAAAEE6Dbi638kUu0iU9Rs4XeAubGX7wY2+/RWSY7piOlTGSqyCLW4ENgJWvDUqOJSAiVg==", "18b63e8f-7f40-4575-81ab-41c2225bbfa9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserLeaveRequests");

            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "UserLeaveRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cancelled",
                table: "UserLeaveRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f4507385-62ca-45f4-9bb9-928f08fe256f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e726e5f5-ce58-4d84-b2cc-24ea6fde0217");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9c930c4-0f66-4546-b8eb-b3969512a454", "AQAAAAEAACcQAAAAEMRCNutCBmWmdgVURjmv9m5t/wlmG0dnNpG/ujMBOtPleyfTitzPfsoasyqCuroKvg==", "876f1fa8-2f05-48ef-b1bc-9031e89960e5" });
        }
    }
}
