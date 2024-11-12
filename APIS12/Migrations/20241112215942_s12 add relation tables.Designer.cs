﻿// <auto-generated />
using System;
using APIS12.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIS12.Migrations
{
    [DbContext(typeof(InvoiceContext))]
    [Migration("20241112215942_s12 add relation tables")]
    partial class s12addrelationtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIS12.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("APIS12.Models.Detail", b =>
                {
                    b.Property<int>("DetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<float>("SubTotal")
                        .HasColumnType("real");

                    b.Property<int>("invoiceID")
                        .HasColumnType("int");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("DetailID");

                    b.HasIndex("invoiceID");

                    b.HasIndex("productID");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("APIS12.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.Property<int>("customerID")
                        .HasColumnType("int");

                    b.HasKey("InvoiceID");

                    b.HasIndex("customerID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("APIS12.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("APIS12.Models.Detail", b =>
                {
                    b.HasOne("APIS12.Models.Invoice", "invoice")
                        .WithMany()
                        .HasForeignKey("invoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIS12.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("invoice");

                    b.Navigation("product");
                });

            modelBuilder.Entity("APIS12.Models.Invoice", b =>
                {
                    b.HasOne("APIS12.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("customerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });
#pragma warning restore 612, 618
        }
    }
}
