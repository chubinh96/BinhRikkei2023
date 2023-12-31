﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication202311.DBContext;

#nullable disable

namespace WebApplication202311.Data.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231217015238_InitialMigration2")]
    partial class InitialMigration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApplication202311.Models.Customer", b =>
                {
                    b.Property<int>("Customer_Cd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Customer_Cd"));

                    b.Property<string>("Customer_Nm")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Customer_Cd");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
