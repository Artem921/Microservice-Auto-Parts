using AutoParts.Infrastructure.Configuration.ContextEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoParts.Infrastructure.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductContext>
    {
        public void Configure(EntityTypeBuilder<ProductContext> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(k => k.Name).IsRequired();
            builder.Property(k => k.VendorName).IsRequired();
            builder.Property(k => k.Description).IsRequired();
            builder.Property(k => k.Manufacture).IsRequired();
            
        }
    }
}
