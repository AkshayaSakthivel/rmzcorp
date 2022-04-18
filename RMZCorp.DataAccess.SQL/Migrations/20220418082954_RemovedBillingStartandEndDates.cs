using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMZCorp.DataAccess.SQL.Migrations
{
    public partial class RemovedBillingStartandEndDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingEndDate",
                table: "WaterMeters");

            migrationBuilder.RenameColumn(
                name: "LitersConsumed",
                table: "WaterMeters",
                newName: "LitersConsumedPerDay");

            migrationBuilder.RenameColumn(
                name: "ConsumptionCost",
                table: "WaterMeters",
                newName: "DailyConsumptionCost");

            migrationBuilder.RenameColumn(
                name: "BillingStartDate",
                table: "WaterMeters",
                newName: "ReadingDate");

            migrationBuilder.RenameColumn(
                name: "OperationalHours",
                table: "ElectricityMeters",
                newName: "OperationalHoursPerDay");

            migrationBuilder.AlterColumn<Guid>(
                name: "SerialNumber",
                table: "WaterMeters",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Facilities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "SerialNumber",
                table: "ElectricityMeters",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReadingDate",
                table: "ElectricityMeters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReadingDate",
                table: "ElectricityMeters");

            migrationBuilder.RenameColumn(
                name: "ReadingDate",
                table: "WaterMeters",
                newName: "BillingStartDate");

            migrationBuilder.RenameColumn(
                name: "LitersConsumedPerDay",
                table: "WaterMeters",
                newName: "LitersConsumed");

            migrationBuilder.RenameColumn(
                name: "DailyConsumptionCost",
                table: "WaterMeters",
                newName: "ConsumptionCost");

            migrationBuilder.RenameColumn(
                name: "OperationalHoursPerDay",
                table: "ElectricityMeters",
                newName: "OperationalHours");

            migrationBuilder.AlterColumn<int>(
                name: "SerialNumber",
                table: "WaterMeters",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<DateTime>(
                name: "BillingEndDate",
                table: "WaterMeters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "Facilities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SerialNumber",
                table: "ElectricityMeters",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }
    }
}
