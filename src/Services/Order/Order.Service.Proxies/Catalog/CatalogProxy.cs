using Microsoft.Extensions.Options;
using Order.Service.Proxies.Catalog.Command;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Order.Service.Proxies.Catalog
{
    public interface ICatalogProxy
    {
        Task UpdateStockAsync(ProductInStockUpdateCommand command);
    }
    public class CatalogProxy : ICatalogProxy
    {
        private readonly ApiUrls _apiUrls;
        private readonly HttpClient _httpClient;

        public CatalogProxy(
            HttpClient httpClient,
            IOptions<ApiUrls> apiUrls
        )
        {
            _httpClient = httpClient;
            _apiUrls = apiUrls.Value;
        }

        public async Task UpdateStockAsync(ProductInStockUpdateCommand command)
        {
            var content = new StringContent(
                JsonSerializer.Serialize(command),
                Encoding.UTF8,
                "application/json"
            );

            var request = await _httpClient.PutAsync(_apiUrls.CatalogUrl + "stocks", content);
            request.EnsureSuccessStatusCode();
        }
    }
}
