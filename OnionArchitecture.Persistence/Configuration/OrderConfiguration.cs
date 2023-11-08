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
    public sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(TableNames.Orders);
            builder.HasKey(t => t.Id);


            builder
                .HasOne(p=>p.Product)
                .WithMany(p=>p.Orders)
                .HasForeignKey(p=>p.ProductId);
        }
    }
}
