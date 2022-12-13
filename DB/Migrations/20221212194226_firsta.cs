using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class firsta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    OfficeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OfficeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.OfficeId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalOrderPrice = table.Column<double>(type: "float", nullable: false),
                    OfficeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BreadOrder",
                columns: table => new
                {
                    BreadOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BreadType = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BreadPrice = table.Column<double>(type: "float", nullable: false),
                    TotalBreadOrderPrice = table.Column<double>(type: "float", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreadOrder", x => x.BreadOrderId);
                    table.ForeignKey(
                        name: "FK_BreadOrder_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BreadOrder_OrderId",
                table: "BreadOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OfficeId",
                table: "Order",
                column: "OfficeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreadOrder");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Office");
        }
    }
}
