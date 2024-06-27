using MultiShop.Catalog.Dtos.FeatureSliderDtos;

namespace MultiShop.Catalog.Services.FeatureSliderServices
{
    public interface IFeatureSliderService
    {
        Task<List<ResultFeatureSliderDto>> GetAllFeatureSliderAsync();
        Task<GetByIdFeatureSliderDto> GetByIdFeatureSliderAsync(string id);
        Task CreateFeatureSliderAsync(CreateFeatureSliderDto FeatureSliderDto);
        Task UpdateFeatureSliderAsync(UpdateFeatureSliderDto FeatureSliderDto);
        Task DeleteFeatureSliderAsync(string id);
        Task FeatureSliderChangeStatusToTrue(string id);
        Task FeatureSliderChangeStatusToFalse(string id);
    }
}
