using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetofinal.Migrations
{
    /// <inheritdoc />
    public partial class Alteracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoria",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "precoDiaria",
                table: "Carros");

            migrationBuilder.AddColumn<int>(
                name: "categoriaid",
                table: "Carros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valorDiaria = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carros_categoriaid",
                table: "Carros",
                column: "categoriaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Carros_Categoria_categoriaid",
                table: "Carros",
                column: "categoriaid",
                principalTable: "Categoria",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carros_Categoria_categoriaid",
                table: "Carros");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Carros_categoriaid",
                table: "Carros");

            migrationBuilder.DropColumn(
                name: "categoriaid",
                table: "Carros");

            migrationBuilder.AddColumn<string>(
                name: "categoria",
                table: "Carros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "precoDiaria",
                table: "Carros",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
