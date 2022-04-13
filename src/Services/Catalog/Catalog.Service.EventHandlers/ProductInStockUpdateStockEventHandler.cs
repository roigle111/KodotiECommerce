using Catalog.Domain;
using Catalog.Persistence.Database;
using Catalog.Service.EventHandlers.Commands;
using Catalog.Service.EventHandlers.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Catalog.Common.Enums;

namespace Catalog.Service.EventHandlers
{
    public class ProductInStockUpdateStockEventHandler : 
        INotificationHandler<ProductInStockUpdateCommand>
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProductInStockUpdateStockEventHandler> _logger;
        public ProductInStockUpdateStockEventHandler(ApplicationDbContext context,
            ILogger<ProductInStockUpdateStockEventHandler> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task Handle(ProductInStockUpdateCommand command, CancellationToken cancellationToken)
        {
            _logger.LogInformation("--- ProductInStockUpdateCommand Comenzó");

            var products = command.Items.Select(x => x.ProductId);
            var stocks = await _context.Stocks.Where(x => products.Contains(x.ProductId)).ToListAsync();

            _logger.LogInformation("--- Obtuvo los productos de la BD");

            foreach (var item in command.Items)
            {
                var entry = stocks.SingleOrDefault(x => x.ProductId == item.ProductId);

                if (item.Action == ProductInStockAction.Substract)
                {
                    if (entry == null || item.Stock > entry.Stock)
                    {
                        _logger.LogError($"--- Producto Id: {entry.ProductId} no tiene stock suficiente");
                        throw new ProductInStockUpdateCommandException($"Producto Id: {entry.ProductId} no tiene stock suficiente");
                    }

                    entry.Stock -= item.Stock;
                    _logger.LogInformation($"--- Producto Id: {entry.ProductId} ha sido extraido. El nuevo stock es: {entry.Stock}");
                }
                else
                {
                    if(entry == null)
                    {
                        entry = new ProductInStock
                        {
                            ProductId = item.ProductId,
                        };

                        await _context.AddAsync(entry);

                        _logger.LogInformation($"--- Se creó un nuevo stock para el prodicto: {entry.ProductId} porque no existía stock antes.");
                    }

                    entry.Stock += item.Stock;

                    _logger.LogInformation($"--- ProductId: {entry.ProductId} fue incrementado el nuevo stock es: {entry.Stock}");
                }
            }

            await _context.SaveChangesAsync();

            _logger.LogInformation("--- ProductInStockUpdateCommand Finzlizó");
        }

    } 
}
