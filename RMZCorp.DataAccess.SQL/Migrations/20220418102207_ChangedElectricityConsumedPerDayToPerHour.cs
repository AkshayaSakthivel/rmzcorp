using Microsoft.EntityFrameworkCore.Migrations;

namespace RMZCorp.DataAccess.SQL.Migrations
{
    public partial class ChangedElectricityConsumedPerDayToPerHour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DailyElecticityConsumed",
                table: "ElectricityMeters",
                newName: "ElecticityConsumedPerHour");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ElecticityConsumedPerHour",
                table: "ElectricityMeters",
                newName: "DailyElecticityConsumed");
        }
    }
}
