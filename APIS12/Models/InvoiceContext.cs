using Microsoft.EntityFrameworkCore;

namespace APIS12.Models
{
    public class InvoiceContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Detail> Details { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DEV\\SQLEXPRESS; Database=DBS12; User ID=userNeptuno; Password=123456; Integrated Security=True; Trust Server Certificate=True ");
        }

        // paquetes a istalar
        // Microsoft.EntityFrameworkCore.sqlserver
        // Microsoft.EntityFrameworkCore
        // Microsoft.EntityFrameworkCore.Tools


        // migracion: add-migration "V1 semana 12"

        // update-database


    }
}
