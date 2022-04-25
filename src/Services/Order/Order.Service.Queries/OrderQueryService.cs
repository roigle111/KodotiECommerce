using Microsoft.EntityFrameworkCore;
using Order.Persistence.Database;
using Order.Service.Queries.DTOs;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Service.Queries
{
    public interface IOrderQueryService
    {
        Task<DataCollection<OrderDto>> GetAllAsync(int page, int take, IEnumerable<int> products = null);
        Task<OrderDto> GetAsync(int id);
    }
    public class OrderQueryService: IOrderQueryService
    {
        private readonly ApplicationDbContext _context;
        public OrderQueryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<OrderDto>> GetAllAsync(int page, int take, IEnumerable<int> products = null)
        {
            var collection = await _context.Orders.Where(x => products == null || products.Contains(x.OrderId))
                                            .OrderByDescending(x => x.OrderId)
                                            .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<OrderDto>>();
        }

        public async Task<OrderDto> GetAsync(int id)
        {
            return (await _context.Orders.SingleAsync(x => x.OrderId == id)).MapTo<OrderDto>();
        }
    }
}
