using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJETO_LOGIN.Migrations
{
    /// <inheritdoc />
    public partial class CriarResultados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Resultados",
                newName: "Resultado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Resultado",
                newName: "Resultados");
        }
    }
}
