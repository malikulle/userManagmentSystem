using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagment.Data.Migrations
{
    public partial class NullableColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Point",
                table: "WorkOrders",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Point",
                table: "WorkOrders",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

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
        }
    }
}
