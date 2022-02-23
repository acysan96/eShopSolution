using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 17, 17, 33, 101, DateTimeKind.Local).AddTicks(9583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 16, 58, 14, 414, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8672b2ff-fa80-46e3-bd2c-9c55e6ad035b"), "45095e51-c325-4dec-8dff-beef6bc5be71", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("45241ba9-a243-46e1-8591-fbe58d4d75b8"), new Guid("8672b2ff-fa80-46e3-bd2c-9c55e6ad035b") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("45241ba9-a243-46e1-8591-fbe58d4d75b8"), 0, "d751f1a3-52bd-4a71-90e2-70bbab240304", new DateTime(2000, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "thangduybt2000@gmail.com", true, "Thang", "Duy", false, null, "thangduybt2000@gmail.com", "admin", "AQAAAAEAACcQAAAAEN5hPXfA4bNzvIp5yY/ua9gcIdv+TH88/YiCt/y3xBw3TCIMMMZZhaGzt5SPBjQ9gA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 23, 17, 17, 33, 137, DateTimeKind.Local).AddTicks(1168));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8672b2ff-fa80-46e3-bd2c-9c55e6ad035b"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("45241ba9-a243-46e1-8591-fbe58d4d75b8"), new Guid("8672b2ff-fa80-46e3-bd2c-9c55e6ad035b") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("45241ba9-a243-46e1-8591-fbe58d4d75b8"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 16, 58, 14, 414, DateTimeKind.Local).AddTicks(5397),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 2, 23, 17, 17, 33, 101, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 23, 16, 58, 14, 436, DateTimeKind.Local).AddTicks(3644));
        }
    }
}
