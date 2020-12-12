using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagment.Data.Migrations
{
    public partial class NewColumnAddedToWorkOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComplatedUserId",
                table: "WorkOrders",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_ComplatedUserId",
                table: "WorkOrders",
                column: "ComplatedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOrders_AspNetUsers_ComplatedUserId",
                table: "WorkOrders",
                column: "ComplatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOrders_AspNetUsers_ComplatedUserId",
                table: "WorkOrders");

            migrationBuilder.DropIndex(
                name: "IX_WorkOrders_ComplatedUserId",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "ComplatedUserId",
                table: "WorkOrders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "158a003a-24ac-4e73-a417-3775775f77f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f585bd53-73e4-4025-94d1-13963e61fd5a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "024ee6bd-aef7-4f62-aa75-ceac672d9577", "AQAAAAEAACcQAAAAEEnFdDJ0Fb2Go0hFjN5vPK5UkhMKbTgB3k3RDhhwckXKarDNXUE9dE0cwUQXkKaAmA==", "4c444e8d-7fc4-4113-89a7-20d5a2ff6ce0" });
        }
    }
}
