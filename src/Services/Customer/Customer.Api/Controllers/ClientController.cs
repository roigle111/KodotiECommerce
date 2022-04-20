using Customer.Services.Queries;
using Customer.Services.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;
using Service.Common.Collection;
using Service.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Api.Controllers
{
    [ApiController]
    [Route("clients")]
    public class ClientController : ControllerBase
    {
        private readonly IClientQueryService _clientQueryService;
        public ClientController(IClientQueryService clientQueryService)
        {
            _clientQueryService = clientQueryService;
        }

        [HttpGet]
        public async Task<DataCollection<ClientDto>> GetAllAsync(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<int> products = null;

            if (!string.IsNullOrEmpty(ids))
            {
                products = ids.Split(",").Select(x => Convert.ToInt32(x));
            }

            return await _clientQueryService.GetAllAsync(page, take, products);
        }

        [HttpGet("{id}")]
        public async Task<ClientDto> GetAsync(int id)
        {
            return await _clientQueryService.GetAsync(id);
        }
    }
}
