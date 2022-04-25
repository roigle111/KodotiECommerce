using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Order.Domain;

namespace Order.Persistence.Database.Configuration
{
    public class OrderDetailConfiguration
    {
        public OrderDetailConfiguration(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => x.OrderDetailId);
            builder.Property(x => x.UnitPrice).HasColumnType("decimal(5,2)");
            builder.Property(x => x.Total).HasColumnType("decimal(5,2)");
        }
    }
}
