using Microsoft.EntityFrameworkCore.Migrations;

namespace RMZCorp.DataAccess.SQL.Migrations
{
    public partial class AddedZoneForeignKeyinWaterMeter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WaterMeters_Zones_ZoneId",
                table: "WaterMeters");

            migrationBuilder.AlterColumn<int>(
                name: "ZoneId",
                table: "WaterMeters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WaterMeters_Zones_ZoneId",
                table: "WaterMeters",
                column: "ZoneId",
                principalTable: "Zones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WaterMeters_Zones_ZoneId",
                table: "WaterMeters");

            migrationBuilder.AlterColumn<int>(
                name: "ZoneId",
                table: "WaterMeters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_WaterMeters_Zones_ZoneId",
                table: "WaterMeters",
                column: "ZoneId",
                principalTable: "Zones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
