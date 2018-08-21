using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpotParkApi.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailabilityEnd",
                table: "ParkingSpot");

            migrationBuilder.DropColumn(
                name: "AvailabilityStart",
                table: "ParkingSpot");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AvailabilityEnd",
                table: "ParkingSpot",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AvailabilityStart",
                table: "ParkingSpot",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
