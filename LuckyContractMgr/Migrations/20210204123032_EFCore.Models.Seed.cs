using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyContractMgr.Migrations
{
    public partial class EFCoreModelsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ContractExecutedOn", "ContractTerminateOn", "PONumber", "PaymentTerms", "RFQNumber", "ScopeOfWork", "TerminationTerms", "VendorCompanyName", "VendorContactPerson" },
                values: new object[] { 1, new DateTime(2021, 2, 4, 13, 30, 31, 4, DateTimeKind.Local).AddTicks(6180), new DateTime(2021, 2, 4, 13, 30, 31, 6, DateTimeKind.Local).AddTicks(5779), "PO00234", "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.", "RFQ000ZHRS", "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.", "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.", "Ochukwu Ltd", "Lucky" });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ContractExecutedOn", "ContractTerminateOn", "PONumber", "PaymentTerms", "RFQNumber", "ScopeOfWork", "TerminationTerms", "VendorCompanyName", "VendorContactPerson" },
                values: new object[] { 2, new DateTime(2021, 2, 4, 13, 30, 31, 6, DateTimeKind.Local).AddTicks(7096), new DateTime(2021, 2, 4, 13, 30, 31, 6, DateTimeKind.Local).AddTicks(7107), "PO00834", "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.", "RFQ00KHGS", "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.", "Time is the indefinite continued progress of existence and events that occur in an apparently irreversible succession from the past, through the present, into the future.", "KK LImited", "Lucky" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
