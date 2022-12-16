using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetofinal.Migrations
{
    /// <inheritdoc />
    public partial class initial01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Aluguelid",
                table: "Aluguel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aluguel_Aluguelid",
                table: "Aluguel",
                column: "Aluguelid");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluguel_Aluguel_Aluguelid",
                table: "Aluguel",
                column: "Aluguelid",
                principalTable: "Aluguel",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluguel_Aluguel_Aluguelid",
                table: "Aluguel");

            migrationBuilder.DropIndex(
                name: "IX_Aluguel_Aluguelid",
                table: "Aluguel");

            migrationBuilder.DropColumn(
                name: "Aluguelid",
                table: "Aluguel");
        }
    }
}
