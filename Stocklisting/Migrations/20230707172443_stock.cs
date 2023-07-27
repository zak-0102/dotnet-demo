using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stocklisting.Migrations
{
    /// <inheritdoc />
    public partial class stock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type_code",
                table: "Shares");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "type_code",
                table: "Shares",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
