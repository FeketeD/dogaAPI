using dogaAPI.Models.Dtos;
using dogaAPI.Models;

namespace dogaAPI.Repositories
{
    public interface IDealerInterface
    {
        Task<IEnumerable<Dealership>> GetDealer();
        Task<Dealership> GetDealerById(Guid Id);
        Task PostDealer(CreateDealerDto createDealerDto);
        Task<Dealership> PutDealer(Guid Id, UpdateDealerDto updateDealerDto);
        Task<Dealership> DeleteDealerById(Guid Id);
    }
}
