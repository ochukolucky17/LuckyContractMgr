using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyContractMgr.Migrations
{
    public partial class Login_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ContractExecutedOn", "ContractTerminateOn" },
                values: new object[] { new DateTime(2021, 2, 8, 17, 51, 15, 95, DateTimeKind.Local).AddTicks(1058), new DateTime(2021, 2, 8, 17, 51, 15, 96, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContractExecutedOn", "ContractTerminateOn" },
                values: new object[] { new DateTime(2021, 2, 8, 17, 51, 15, 96, DateTimeKind.Local).AddTicks(3985), new DateTime(2021, 2, 8, 17, 51, 15, 96, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "LoginModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserName",
                value: "Lucky2");

            migrationBuilder.InsertData(
                table: "LoginModels",
                columns: new[] { "Id", "EmailAddress", "FullName", "Password", "Telephone", "UserName" },
                values: new object[] { 3, "Lucky@ContractManager.com", "Lucky Okorodiden", "Lucky@123", "081487282912", "Lucky3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LoginModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ContractExecutedOn", "ContractTerminateOn" },
                values: new object[] { new DateTime(2021, 2, 4, 20, 37, 5, 727, DateTimeKind.Local).AddTicks(9658), new DateTime(2021, 2, 4, 20, 37, 5, 730, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContractExecutedOn", "ContractTerminateOn" },
                values: new object[] { new DateTime(2021, 2, 4, 20, 37, 5, 730, DateTimeKind.Local).AddTicks(2286), new DateTime(2021, 2, 4, 20, 37, 5, 730, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "LoginModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserName",
                value: "Lucky1");
        }
    }
}
