using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopQuanAoSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopQuanAoSolution.Data.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        { 

            builder.ToTable("Product");
            builder.HasKey(m => m.ID);

            builder.Property(m => m.name);
            builder.Property(m => m.slug);
            builder.Property(m => m.parentid);
            builder.HasKey(m => m.ID);
            builder.HasKey(m => m.ID);
            builder.HasKey(m => m.ID);
            builder.HasKey(m => m.ID);
        }
    }
}
