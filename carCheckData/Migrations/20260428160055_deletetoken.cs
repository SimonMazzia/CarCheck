using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carCheckData.Migrations
{
    /// <inheritdoc />
    public partial class deletetoken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) => migrationBuilder.DropColumn(
                name: "TokenRecuperacion",
                table: "Usuarios");

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) => migrationBuilder.AddColumn<string>(
                name: "TokenRecuperacion",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
    }
}
