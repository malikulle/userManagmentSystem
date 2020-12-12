using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagment.Data.Migrations
{
    public partial class NameChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLeaveRequests_AspNetUsers_UserId",
                table: "UserLeaveRequests");

            migrationBuilder.DropIndex(
                name: "IX_UserLeaveRequests_UserId",
                table: "UserLeaveRequests");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserLeaveRequests");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserLeaveRequests_ApprovedUserId",
                table: "UserLeaveRequests",
                column: "ApprovedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLeaveRequests_AspNetUsers_ApprovedUserId",
                table: "UserLeaveRequests",
                column: "ApprovedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLeaveRequests_AspNetUsers_ApprovedUserId",
                table: "UserLeaveRequests");

            migrationBuilder.DropIndex(
                name: "IX_UserLeaveRequests_ApprovedUserId",
                table: "UserLeaveRequests");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserLeaveRequests",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9477cfbe-caf2-4fe8-a8a1-6a6aa8c47d08");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "cf7e6549-13fb-4875-adfe-d644b7404b78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76b4357b-cec9-41b4-8e0a-ae0ab80309f6", "AQAAAAEAACcQAAAAELoq6vpo/BvSrl9WhDpv4TV2xy2/4IQdY0MPEmYigNRdbhj6uS5pCkrJLwKBtXCzrQ==", "c303d542-269d-4e0d-9685-402085d7747b" });

            migrationBuilder.CreateIndex(
                name: "IX_UserLeaveRequests_UserId",
                table: "UserLeaveRequests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLeaveRequests_AspNetUsers_UserId",
                table: "UserLeaveRequests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
