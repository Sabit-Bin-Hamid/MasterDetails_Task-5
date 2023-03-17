using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterDetails.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    PurchaseId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    EntryBy = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(800)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.PurchaseId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseDetailss",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ItemQty = table.Column<float>(type: "real", nullable: false),
                    ItemUnitId = table.Column<float>(type: "real", nullable: false),
                    ItemRate = table.Column<float>(type: "real", nullable: false),
                    PurchaseId = table.Column<int>(type: "int", nullable: false),
                    PurchaseId1 = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseDetailss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseDetailss_Purchases_PurchaseId1",
                        column: x => x.PurchaseId1,
                        principalTable: "Purchases",
                        principalColumn: "PurchaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetailss_PurchaseId1",
                table: "PurchaseDetailss",
                column: "PurchaseId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseDetailss");

            migrationBuilder.DropTable(
                name: "Purchases");
        }
    }
}
