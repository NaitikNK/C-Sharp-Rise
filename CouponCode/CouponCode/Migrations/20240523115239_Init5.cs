using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CouponCode.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "notification");

            migrationBuilder.AddColumn<string>(
                name: "MealId",
                table: "notification",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MealId",
                table: "notification");

            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "notification",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
