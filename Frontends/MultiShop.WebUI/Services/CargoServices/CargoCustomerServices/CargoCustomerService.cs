﻿using MultiShop.DtoLayer.CargoDtos.CargoCustomerDtos;

namespace MultiShop.WebUI.Services.CargoServices.CargoCustomerServices
{
    public class CargoCustomerService : ICargoCustomerService
    {
        private readonly HttpClient _httpClient;

        public CargoCustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<GetCargoCustomerByIdDto> GetByIdCargoCustomerAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync("cargocustomers/getcargocustomerbyid?id=" + id);
            var value = await responseMessage.Content.ReadFromJsonAsync<GetCargoCustomerByIdDto>();
            return value;
        }
    }
}
