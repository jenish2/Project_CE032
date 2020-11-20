using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMyTickets.Migrations
{
    public partial class BookingTableKeyUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Bookings",
                newName: "BookingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "Bookings",
                newName: "OrderId");
        }
    }
}
