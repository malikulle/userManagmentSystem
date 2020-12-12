using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagment.Data.Migrations
{
    public partial class EmployeeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserLeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DefaultDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLeaveAllocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    NumberOfDays = table.Column<int>(nullable: false),
                    Period = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserLeaveTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLeaveAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLeaveAllocations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLeaveAllocations_UserLeaveTypes_UserLeaveTypeId",
                        column: x => x.UserLeaveTypeId,
                        principalTable: "UserLeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    RequestUserId = table.Column<int>(nullable: false),
                    ApprovedUserId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    UserLeaveTypeId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    RequestDate = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Approved = table.Column<bool>(nullable: false),
                    Cancelled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLeaveRequests_AspNetUsers_RequestUserId",
                        column: x => x.RequestUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLeaveRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserLeaveRequests_UserLeaveTypes_UserLeaveTypeId",
                        column: x => x.UserLeaveTypeId,
                        principalTable: "UserLeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_UserLeaveAllocations_UserId",
                table: "UserLeaveAllocations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLeaveAllocations_UserLeaveTypeId",
                table: "UserLeaveAllocations",
                column: "UserLeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLeaveRequests_RequestUserId",
                table: "UserLeaveRequests",
                column: "RequestUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLeaveRequests_UserId",
                table: "UserLeaveRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLeaveRequests_UserLeaveTypeId",
                table: "UserLeaveRequests",
                column: "UserLeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLeaveAllocations");

            migrationBuilder.DropTable(
                name: "UserLeaveRequests");

            migrationBuilder.DropTable(
                name: "UserLeaveTypes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "438ef2a5-5141-432c-8463-b4bf1e360f09");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3636d036-9ed6-4aa0-92c6-b64143753e5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14b33c7c-522c-4631-959c-9a63f20618fe", "AQAAAAEAACcQAAAAEE9UOItPqUQaIuGXoW28E7f5wowfT49nUYOS0bLY7leOUPlJSlw1Qe/HF42HKz9WQQ==", "fda47016-13b6-4677-a3cc-b79ed4e6982c" });
        }
    }
}
