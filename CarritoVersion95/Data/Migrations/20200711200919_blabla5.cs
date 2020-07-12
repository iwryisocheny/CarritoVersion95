using Microsoft.EntityFrameworkCore.Migrations;

namespace CarritoVersion95.Data.Migrations
{
    public partial class blabla5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPedido",
                table: "Items",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPedido",
                table: "Items");
        }
    }
}
