using Microsoft.EntityFrameworkCore.Migrations;

namespace CarritoVersion95.Data.Migrations
{
    public partial class blabla3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "contrasenia",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(nullable: false),
                    PrecioTotal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IdPedido);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    IdItem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProducto = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio = table.Column<double>(nullable: false),
                    IdTienda = table.Column<int>(nullable: false),
                    NombreProducto = table.Column<string>(nullable: true),
                    PedidoIdPedido = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.IdItem);
                    table.ForeignKey(
                        name: "FK_Items_Pedidos_PedidoIdPedido",
                        column: x => x.PedidoIdPedido,
                        principalTable: "Pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_PedidoIdPedido",
                table: "Items",
                column: "PedidoIdPedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "contrasenia",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
