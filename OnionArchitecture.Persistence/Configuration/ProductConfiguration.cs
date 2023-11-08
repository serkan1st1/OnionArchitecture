using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Persistance.Constans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistance.Configuration
{
    public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(TableNames.Products);
            builder.HasKey(p => p.Id);

            builder
                .HasOne(p=>p.Company)
                .WithMany(p=>p.Products)
                .HasForeignKey(p=>p.CompanyId);

            builder.Property(p => p.Price).HasColumnType("money");
            builder.Property(p => p.Stock).HasColumnType("decimal(18,2)");
        }
    }
}
