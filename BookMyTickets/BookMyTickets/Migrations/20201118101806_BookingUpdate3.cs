using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMyTickets.Migrations
{
    public partial class BookingUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeatNo1",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeatNo2",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeatNo3",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatNo1",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "SeatNo2",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "SeatNo3",
                table: "Bookings");
        }
    }
}
