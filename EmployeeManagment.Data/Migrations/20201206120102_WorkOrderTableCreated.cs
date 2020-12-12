using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagment.Data.Migrations
{
    public partial class WorkOrderTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: false),
                    AssignUserId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    WorkOrderStatus = table.Column<int>(nullable: false),
                    Point = table.Column<double>(nullable: false),
                    WorkOrderNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOrders_AspNetUsers_AssignUserId",
                        column: x => x.AssignUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkOrders_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2cd9271a-818c-4f1e-838a-a6402ccbf1c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9954b3ab-33c4-4090-b4d0-10a42fd2efdd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b962ac3c-6f9e-44c9-be5e-8987721b73e2", "AQAAAAEAACcQAAAAEPPB1O4tWsdROaobHwMwzONoxqGB5fIN5Uh3rhLqNEPVD9+GoV46BImDR4pzta8s9Q==", "66f63f10-489b-4404-9160-7268db2b13cb" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_AssignUserId",
                table: "WorkOrders",
                column: "AssignUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_CreatedUserId",
                table: "WorkOrders",
                column: "CreatedUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkOrders");

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
    }
}
