using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlatExpenseCalculator.Data.Migrations
{
    public partial class rentPerRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "RentPerWeek",
                table: "Room",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CurrentTotalExpenses",
                table: "Property",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentPerWeek",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "CurrentTotalExpenses",
                table: "Property");
        }
    }
}
