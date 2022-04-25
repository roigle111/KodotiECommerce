using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Order.Persistence.Database.Configuration
{
    public class OrderConfiguration 
    {
        public OrderConfiguration(EntityTypeBuilder<Domain.Order> builder)
        {
            builder.HasKey(x => x.OrderId);
            builder.Property(x => x.Total).HasColumnType("decimal(5,2)");
        }
    }
}
