using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LuckyContractMgr.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsContractContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RFQNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PONumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScopeOfWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminationTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractExecutedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractTerminateOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");
        }
    }
}
