using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIS12.Migrations
{
    /// <inheritdoc />
    public partial class s12addrelationtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "customerid",
                table: "Invoices",
                newName: "customerID");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "Details",
                newName: "productID");

            migrationBuilder.RenameColumn(
                name: "invoiceid",
                table: "Details",
                newName: "invoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_customerID",
                table: "Invoices",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_Details_invoiceID",
                table: "Details",
                column: "invoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Details_productID",
                table: "Details",
                column: "productID");

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Invoices_invoiceID",
                table: "Details",
                column: "invoiceID",
                principalTable: "Invoices",
                principalColumn: "InvoiceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Products_productID",
                table: "Details",
                column: "productID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Customers_customerID",
                table: "Invoices",
                column: "customerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Invoices_invoiceID",
                table: "Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Details_Products_productID",
                table: "Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Customers_customerID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_customerID",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Details_invoiceID",
                table: "Details");

            migrationBuilder.DropIndex(
                name: "IX_Details_productID",
                table: "Details");

            migrationBuilder.RenameColumn(
                name: "customerID",
                table: "Invoices",
                newName: "customerid");

            migrationBuilder.RenameColumn(
                name: "productID",
                table: "Details",
                newName: "productid");

            migrationBuilder.RenameColumn(
                name: "invoiceID",
                table: "Details",
                newName: "invoiceid");
        }
    }
}
