using MultiShop.DtoLayer.CatalogDtos.BrandDtos;

namespace MultiShop.WebUI.Services.CatalogServices.BrandServices
{
    public interface IBrandService
    {
        Task<List<ResultBrandDto>> GetAllBrandAsync();
        Task<UpdateBrandDto> GetByIdBrandAsync(string id);
        Task CreateBrandAsync(CreateBrandDto BrandDto);
        Task UpdateBrandAsync(UpdateBrandDto BrandDto);
        Task DeleteBrandAsync(string id);
    }
}
