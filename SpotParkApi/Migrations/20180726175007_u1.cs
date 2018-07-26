using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpotParkApi.Migrations
{
    public partial class u1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Availability",
                table: "ParkingSpot",
                newName: "AvailabilityStart");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ParkingSpot",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialInstructions",
                table: "ParkingSpot",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Size",
                table: "ParkingSpot",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "LocationIdentifier",
                table: "ParkingSpot",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "ParkingSpot",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ParkingSpot",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AvailabilityEnd",
                table: "ParkingSpot",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailabilityEnd",
                table: "ParkingSpot");

            migrationBuilder.RenameColumn(
                name: "AvailabilityStart",
                table: "ParkingSpot",
                newName: "Availability");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ParkingSpot",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialInstructions",
                table: "ParkingSpot",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "ParkingSpot",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "LocationIdentifier",
                table: "ParkingSpot",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "ParkingSpot",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ParkingSpot",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
