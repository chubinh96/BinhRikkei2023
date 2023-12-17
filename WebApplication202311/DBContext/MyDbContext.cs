using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication202311.Models;
using System.Linq;

namespace WebApplication202311.DBContext
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Shain> Shains { get; set; }

        public DbSet<Employ> Employs { get; set; }

        public DbSet<Kaisha> Kaishas { get; set; }


        public string GetDbCustomerName()
        {
            var entityType = Model.FindEntityType(typeof(Customer));
            var tableName = entityType.GetTableName();

            // Đây là tên thực tế của cơ sở dữ liệu tương ứng với DbSet
            return tableName;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Sử dụng Fluent API để xác định khóa chính
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.Customer_Cd);

            modelBuilder.Entity<Shain>()
                .HasKey(c => c.Shain_Cd);

            modelBuilder.Entity<Employ>()
                .HasKey(c => c.EmployId);

            modelBuilder.Entity<Kaisha>()
                .HasKey(c => c.KaishaId);

        }

    }
}
