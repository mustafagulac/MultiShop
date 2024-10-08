﻿
namespace MultiShop.WebUI.Services.StatisticServices.CatalogStatisticServices
{
    public class CatalogStatisticService : ICatalogStatisticService
    {
        private readonly HttpClient _httpClient;

        public CatalogStatisticService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<long> GetBrandCount()
        {
            var responseMessage = await _httpClient.GetAsync("statistics/getbrandcount");
            var value = await responseMessage.Content.ReadFromJsonAsync<long>();
            return value;
        }

        public async Task<long> GetCategoryCount()
        {
            var responseMessage = await _httpClient.GetAsync("statistics/getcategorycount");
            var value = await responseMessage.Content.ReadFromJsonAsync<long>();
            return value;
        }

        public async Task<string> GetMaxPriceProductName()
        {
            var responseMessage = await _httpClient.GetAsync("statistics/getmaxpriceproductname");
            var value = await responseMessage.Content.ReadAsStringAsync();
            return value;
        }

        public async Task<string> GetMinPriceProductName()
        {
            var responseMessage = await _httpClient.GetAsync("statistics/getminpriceproductname");
            var value = await responseMessage.Content.ReadAsStringAsync();
            return value;
        }

        public async Task<decimal> GetProductAvgPrice()
        {
            var responseMessage = await _httpClient.GetAsync("statistics/getproductavgprice");
            var value = await responseMessage.Content.ReadFromJsonAsync<decimal>();
            return value;
        }

        public async Task<long> GetProductCount()
        {
            var responseMessage = await _httpClient.GetAsync("statistics/getproductcount");
            var value = await responseMessage.Content.ReadFromJsonAsync<long>();
            return value;
        }
    }
}
