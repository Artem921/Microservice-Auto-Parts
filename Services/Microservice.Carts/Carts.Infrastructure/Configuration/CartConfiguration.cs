using Carts.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carts.Infrastructure.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<CartContext>
    {
        public void Configure(EntityTypeBuilder<CartContext> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
