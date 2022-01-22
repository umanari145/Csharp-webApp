using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options) { }

        public DbSet<Product> Product { get; set; }
    }
}
