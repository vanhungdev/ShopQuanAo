using Microsoft.EntityFrameworkCore;
using ShopQuanAoSolution.Data.Configurations;
using ShopQuanAoSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopQuanAoSolution.Data.EF
{
    public class ShopQuanAoDbContex : DbContext
    {
        ShopQuanAoDbContex(DbContextOptions options):base(options) { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
        public DbSet<Product> Products { get; set; }
    }
}
