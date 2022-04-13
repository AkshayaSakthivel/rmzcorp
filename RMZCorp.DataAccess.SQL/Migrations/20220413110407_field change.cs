using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMZCorp.DataAccess.SQL.Migrations
{
    public partial class fieldchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingEndDate",
                table: "ElectricityMeters");

            migrationBuilder.DropColumn(
                name: "BillingStartDate",
                table: "ElectricityMeters");

            migrationBuilder.RenameColumn(
                name: "ElecticityConsumedCost",
                table: "ElectricityMeters",
                newName: "DailyElecticityConsumedCost");

            migrationBuilder.RenameColumn(
                name: "ElecticityConsumed",
                table: "ElectricityMeters",
                newName: "DailyElecticityConsumed");

            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "Facilities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Facilities");

            migrationBuilder.RenameColumn(
                name: "DailyElecticityConsumedCost",
                table: "ElectricityMeters",
                newName: "ElecticityConsumedCost");

            migrationBuilder.RenameColumn(
                name: "DailyElecticityConsumed",
                table: "ElectricityMeters",
                newName: "ElecticityConsumed");

            migrationBuilder.AddColumn<DateTime>(
                name: "BillingEndDate",
                table: "ElectricityMeters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BillingStartDate",
                table: "ElectricityMeters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
