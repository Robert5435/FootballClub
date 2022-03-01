using Microsoft.EntityFrameworkCore.Migrations;

namespace Football.Data.Migrations
{
    public partial class Player_Number : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "StaffMembers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerNumber",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "StaffMembers");

            migrationBuilder.DropColumn(
                name: "PlayerNumber",
                table: "Players");
        }
    }
}
