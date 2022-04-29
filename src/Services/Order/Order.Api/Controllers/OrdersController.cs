using MediatR;
using Microsoft.AspNetCore.Mvc;
using Order.Service.EventHandlers.Commands;
using Order.Service.Queries;
using Order.Service.Queries.DTOs;
using Service.Common.Collection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Api.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderQueryService _orderQueryService;
        private readonly IMediator _mediator;
        public OrdersController(IOrderQueryService orderQueryService, IMediator mediator)
        {
            _orderQueryService = orderQueryService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<OrderDto>> GetAllAsync(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<int> products = null;

            if (!string.IsNullOrEmpty(ids))
            {
                products = ids.Split(",").Select(x => Convert.ToInt32(x));
            }

            return await _orderQueryService.GetAllAsync(page, take, products);
        }

        [HttpGet("{id}")]
        public async Task<OrderDto> GetAsync(int id)
        {
            return await _orderQueryService.GetAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderCreateCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }

    }
}