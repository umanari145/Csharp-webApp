using log4net;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using WebApplication1.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebApplication1.Data
{
    public class DataContext : DbContext
    {
        private readonly ILog _logger;

        private readonly string _connectionString;

        public DataContext()
        {
            _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //appsettingsから値を取得
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                          .AddJsonFile("appsettings.json", true, true).Build();
            IConfigurationSection section = configuration.GetSection("ConnectionStrings");
            _connectionString = section["sqlserver"];

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(_connectionString)
                             .LogTo(message =>_logger.Debug(message));


        public DbSet<Item> Items { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item { Id = "0000000001", Name = "Book", Price = 1000 },
                new Item { Id = "0000000002", Name = "Pen", Price = 500 },
                new Item { Id = "0000000003", Name = "Laptop", Price = 300 }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = "cus0000001", Name = "Yamada", },
                new Customer { Id = "cus0000002", Name = "Suzuki"},
                new Customer { Id = "cus0000003", Name = "Watanabe"  }
            );
        }
    }
}
