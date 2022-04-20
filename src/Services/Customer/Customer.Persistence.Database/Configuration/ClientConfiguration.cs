using Customer.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Customer.Persistence.Database.Configuration
{
    public class ClientConfiguration
    {
        public ClientConfiguration(EntityTypeBuilder<Client> builder)
        {
            builder.HasIndex(x => x.ClientId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            var newClient = new Client { Name = "Roigle111", ClientId = 1 };
            builder.HasData(newClient);
        }
    }
}
