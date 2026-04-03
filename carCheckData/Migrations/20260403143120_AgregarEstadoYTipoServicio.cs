using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carCheckData.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEstadoYTipoServicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoServicio",
                table: "Servicios",
                newName: "TipoServicioId");

            migrationBuilder.CreateTable(
                name: "TipoServicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoServicio", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_TipoServicioId",
                table: "Servicios",
                column: "TipoServicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_TipoServicio_TipoServicioId",
                table: "Servicios",
                column: "TipoServicioId",
                principalTable: "TipoServicio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_TipoServicio_TipoServicioId",
                table: "Servicios");

            migrationBuilder.DropTable(
                name: "TipoServicio");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_TipoServicioId",
                table: "Servicios");

            migrationBuilder.RenameColumn(
                name: "TipoServicioId",
                table: "Servicios",
                newName: "TipoServicio");
        }
    }
}
