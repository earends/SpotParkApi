using Microsoft.EntityFrameworkCore.Migrations;

namespace SpotParkApi.Migrations
{
    public partial class u7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_ParkingSpot_ParkingSpotID",
                table: "Report");

            migrationBuilder.AlterColumn<long>(
                name: "ParkingSpotID",
                table: "Report",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_ParkingSpot_ParkingSpotID",
                table: "Report",
                column: "ParkingSpotID",
                principalTable: "ParkingSpot",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Report_ParkingSpot_ParkingSpotID",
                table: "Report");

            migrationBuilder.AlterColumn<long>(
                name: "ParkingSpotID",
                table: "Report",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_Report_ParkingSpot_ParkingSpotID",
                table: "Report",
                column: "ParkingSpotID",
                principalTable: "ParkingSpot",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
