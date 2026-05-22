using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carCheckData.Migrations
{
    /// <inheritdoc />
    public partial class pinhash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) => migrationBuilder.AddColumn<string>(
                name: "PinHash",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) => migrationBuilder.DropColumn(
                name: "PinHash",
                table: "Usuarios");
    }
}
