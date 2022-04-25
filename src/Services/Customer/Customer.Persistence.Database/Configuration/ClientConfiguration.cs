using Customer.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Customer.Persistence.Database.Configuration
{
    public class ClientConfiguration
    {
        public ClientConfiguration(EntityTypeBuilder<Client> builder)
        {
            builder.HasIndex(x => x.ClientId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            List<Client> listClient = new List<Client>();

            for (int i = 1; i <= 10; i++)
            {
                listClient.Add(new Client
                {
                    ClientId = i,
                    Name = "Client-" + i
                });
            }

            builder.HasData(listClient);
        }
    }
}
