using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShopQuanAoSolution.Data.EF
{
    class EShopDbContextFactory : IDesignTimeDbContextFactory<ShopQuanAoDbContex>
    {
        public ShopQuanAoDbContex CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("eShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<ShopQuanAoDbContex>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopQuanAoDbContex(optionsBuilder.Options);
        }
    }
}
