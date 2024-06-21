using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoDetailDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailsController(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }

        [HttpGet]
        public IActionResult CargoDetailList()
        {
            var values = _cargoDetailService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
        {
            //mapleme islemini manuel olarak yapiyoruz
            CargoDetail CargoDetail = new CargoDetail()
            {
                Barcode = createCargoDetailDto.Barcode,
                CargoCompanyId = createCargoDetailDto.CargoCompanyId,
                ReceiverCustomer = createCargoDetailDto.ReceiverCustomer,
                SenderCustomer = createCargoDetailDto.SenderCustomer,
            };
            _cargoDetailService.TInsert(CargoDetail);
            return Ok("Kargo Detaylari Basariyla Olusturuldu");
        }

        [HttpDelete]
        public IActionResult RemoveCargoDetail(int id)
        {
            _cargoDetailService.TDelete(id);
            return Ok("Kargo Detaylari Basariyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoDetailById(int id)
        {
            var value = _cargoDetailService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
        {
            CargoDetail CargoDetail = new CargoDetail()
            {
                Barcode=updateCargoDetailDto.Barcode,
                CargoCompanyId = updateCargoDetailDto.CargoCompanyId,
                CargoDetailId = updateCargoDetailDto.CargoDetailId,
                ReceiverCustomer=updateCargoDetailDto.ReceiverCustomer,
                SenderCustomer=updateCargoDetailDto.SenderCustomer,

            };
            _cargoDetailService.TUpdate(CargoDetail);
            return Ok("Kargo Detaylari Basariyla Guncellendi");
        }
    }
}
