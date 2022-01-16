using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class MyContext : System.Data.Entity.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Product> Products { get; set; }

        public MyContext(DbContextOptions options): base(options) { }

        public void addProduct()
        {
            var context = new MyContext();
            context.Products.Add(new Product{
                Name = "Test",
                Price = 1000,
            });

            // SaveChangesが呼び出された段階で初めてInsert文が発行される
            context.SaveChanges();
        }


    }
}
