﻿using MultiShop.Catalog.Dtos.ProductImageDtos;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GetAllProductImageAsync();
        Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);
        Task CreateProductImageAsync(CreateProductImageDto ProductImageDto);
        Task UpdateProductImageAsync(UpdateProductImageDto ProductImageDto);
        Task DeleteProductImageAsync(string id);
    }
}