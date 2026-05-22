using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carCheckData.Migrations
{
    /// <inheritdoc />
    public partial class strigchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) => migrationBuilder.AlterColumn<string>(
                name: "TokenRecuperacion",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) => migrationBuilder.AlterColumn<string>(
                name: "TokenRecuperacion",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
    }
}
