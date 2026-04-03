using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carCheckData.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEstado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_TipoServicio_TipoServicioId",
                table: "Servicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoServicio",
                table: "TipoServicio");

            migrationBuilder.RenameTable(
                name: "TipoServicio",
                newName: "TiposServicio");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "Servicios",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposServicio",
                table: "TiposServicio",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_EstadoId",
                table: "Servicios",
                column: "EstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Estados_EstadoId",
                table: "Servicios",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_TiposServicio_TipoServicioId",
                table: "Servicios",
                column: "TipoServicioId",
                principalTable: "TiposServicio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Estados_EstadoId",
                table: "Servicios");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_TiposServicio_TipoServicioId",
                table: "Servicios");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_EstadoId",
                table: "Servicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposServicio",
                table: "TiposServicio");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Servicios");

            migrationBuilder.RenameTable(
                name: "TiposServicio",
                newName: "TipoServicio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoServicio",
                table: "TipoServicio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_TipoServicio_TipoServicioId",
                table: "Servicios",
                column: "TipoServicioId",
                principalTable: "TipoServicio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
