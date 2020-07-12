using Microsoft.EntityFrameworkCore.Migrations;

namespace CarritoVersion95.Data.Migrations
{
    public partial class blabla6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Pedidos_PedidoIdPedido",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "PedidoIdPedido",
                table: "Items",
                newName: "pedidoIdPedido");

            migrationBuilder.RenameIndex(
                name: "IX_Items_PedidoIdPedido",
                table: "Items",
                newName: "IX_Items_pedidoIdPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Pedidos_pedidoIdPedido",
                table: "Items",
                column: "pedidoIdPedido",
                principalTable: "Pedidos",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Pedidos_pedidoIdPedido",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "pedidoIdPedido",
                table: "Items",
                newName: "PedidoIdPedido");

            migrationBuilder.RenameIndex(
                name: "IX_Items_pedidoIdPedido",
                table: "Items",
                newName: "IX_Items_PedidoIdPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Pedidos_PedidoIdPedido",
                table: "Items",
                column: "PedidoIdPedido",
                principalTable: "Pedidos",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
