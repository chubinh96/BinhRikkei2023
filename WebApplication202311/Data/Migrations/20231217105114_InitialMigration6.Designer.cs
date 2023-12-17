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
    [Migration("20231217105114_InitialMigration6")]
    partial class InitialMigration6
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

            modelBuilder.Entity("WebApplication202311.Models.Employ", b =>
                {
                    b.Property<int>("EmployId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployId"));

                    b.Property<string>("EmployName")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("EmployId");

                    b.ToTable("Employs");
                });

            modelBuilder.Entity("WebApplication202311.Models.Kaisha", b =>
                {
                    b.Property<int>("KaishaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("KaishaId"));

                    b.Property<string>("KaishaAdress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KaishaCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KaishaName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("KaishaId");

                    b.ToTable("Kaishas");
                });

            modelBuilder.Entity("WebApplication202311.Models.Shain", b =>
                {
                    b.Property<int>("Shain_Cd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Shain_Cd"));

                    b.Property<string>("Shain_Nm")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Shain_Cd");

                    b.ToTable("Shains");
                });
#pragma warning restore 612, 618
        }
    }
}
