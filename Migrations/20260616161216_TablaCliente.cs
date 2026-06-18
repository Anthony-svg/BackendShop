using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class TablaCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Cliente",
                newName: "TelefonoCliente");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "IdCliente");

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockDisponible = table.Column<int>(type: "int", nullable: false),
                    ReponerStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.ProductoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.RenameColumn(
                name: "TelefonoCliente",
                table: "Cliente",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Cliente",
                newName: "Id");
        }
    }
}
