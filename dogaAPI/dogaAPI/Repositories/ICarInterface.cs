using dogaAPI.Models;
using dogaAPI.Models.Dtos;

namespace dogaAPI.Repositories
{
    public interface ICarInterface
    {
        Task<IEnumerable<Cars>> Get();
        Task<Cars> GetById(Guid Id);
        Task PostCar(CreateCarDto createCarDto);
        Task<Cars> PutCar(Guid Id, UpdateCarDto updateCarDto);
        Task<Cars> DeleteById(Guid Id);
    }
}
