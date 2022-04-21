using Customer.Domain;
using Customer.Persistence.Database;
using Customer.Service.EventHandlers.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Service.EventHandlers
{
    public class ClientCreateEventHandlers : INotificationHandler<ClientCreateCommand>
    {
        private readonly ApplicationDbContext _context;
        public ClientCreateEventHandlers(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ClientCreateCommand command, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Client
            {
                Name = command.Name
            });

            await _context.SaveChangesAsync();
        }

    }
}
