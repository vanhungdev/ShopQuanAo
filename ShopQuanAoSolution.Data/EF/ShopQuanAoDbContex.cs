using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopQuanAoSolution.Data.EF
{
    public class ShopQuanAoDbContex : DbContext
    {
        ShopQuanAoDbContex(DbContextOptions options):base(options) { 
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }
    }
}
