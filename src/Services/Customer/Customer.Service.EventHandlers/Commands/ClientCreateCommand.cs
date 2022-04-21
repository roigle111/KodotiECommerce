using MediatR;

namespace Customer.Service.EventHandlers.Commands
{
    public class ClientCreateCommand : INotification
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
    }
}
