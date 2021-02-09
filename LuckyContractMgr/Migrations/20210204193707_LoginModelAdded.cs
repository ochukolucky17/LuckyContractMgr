using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyContractMgr.Migrations
{
    public partial class LoginModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginModels", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "LoginModels",
                columns: new[] { "Id", "EmailAddress", "FullName", "Password", "Telephone", "UserName" },
                values: new object[,]
                {
                    { 1, "Lucky@ContractManager.com", "Lucky Okorodiden", "Lucky@123", "081487282912", "Lucky1" },
                    { 2, "Lucky@ContractManager.com", "Lucky Okorodiden", "Lucky@123", "081487282912", "Lucky1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginModels");

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ContractExecutedOn", "ContractTerminateOn" },
                values: new object[] { new DateTime(2021, 2, 4, 13, 30, 31, 4, DateTimeKind.Local).AddTicks(6180), new DateTime(2021, 2, 4, 13, 30, 31, 6, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContractExecutedOn", "ContractTerminateOn" },
                values: new object[] { new DateTime(2021, 2, 4, 13, 30, 31, 6, DateTimeKind.Local).AddTicks(7096), new DateTime(2021, 2, 4, 13, 30, 31, 6, DateTimeKind.Local).AddTicks(7107) });
        }
    }
}
