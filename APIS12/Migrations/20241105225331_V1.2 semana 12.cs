using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIS12.Migrations
{
    /// <inheritdoc />
    public partial class V12semana12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Productts",
                table: "Productts");

            migrationBuilder.RenameTable(
                name: "Productts",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Productts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productts",
                table: "Productts",
                column: "ProductID");
        }
    }
}
