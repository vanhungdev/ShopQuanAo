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
            builder.HasKey(m=>m.ID);
            builder.Property(m => m.ID).UseIdentityColumn();
            builder.Property(m => m.catid).IsRequired();
            builder.Property(m => m.name).IsRequired().IsUnicode().HasMaxLength(255);
            builder.Property(m => m.img).IsRequired().HasMaxLength(255);
            builder.Property(m => m.description).IsRequired().HasColumnType("ntext");
            builder.Property(m => m.sold).IsRequired().HasDefaultValue(0);
            builder.Property(m => m.number).IsRequired().HasDefaultValue(30); ;
            builder.Property(m => m.price).IsRequired();
            builder.Property(m => m.created_at).IsRequired();
            builder.Property(m => m.created_by).IsRequired();
            builder.Property(m => m.status).IsRequired(); ;
        }
    }
}
