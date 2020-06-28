﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class AddedOrder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Order_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryName",
                value: "Sezonowe ciasta");

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                column: "Name",
                value: "Ciasto rabarbarowe");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderId");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryName",
                value: "sezonowe ciasta");

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                column: "Name",
                value: "ciasto rabarbarowe");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Order_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
