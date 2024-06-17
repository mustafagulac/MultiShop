﻿using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
        Task CreateProductAsync(CreateProductDto ProductDto);
        Task UpdateProductAsync(UpdateProductDto ProductDto);
        Task DeleteProductAsync(string id);
    }
}
