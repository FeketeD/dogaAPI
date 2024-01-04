using dogaAPI.Models;
using dogaAPI.Models.Dtos;

namespace dogaAPI
{
    public static class Extensions
    {
        public static CarDto AsDto(this CarDto carDto)
        {
            return new(carDto.Id, carDto.Brand, carDto.Model, carDto.Price, carDto.CretedDate);
        }
        public static DealerDto AsDealerDto(this DealerDto dealerDto)
        {
            return new(dealerDto.Id, dealerDto.Name, dealerDto.Address, dealerDto.CarsId, dealerDto.CretedDate);
        }
    }
}
