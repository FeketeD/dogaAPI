using dogaAPI.Models.Dtos;
using dogaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace dogaAPI.Repositories
{
    public class DealerService : IDealerInterface
    {
        public readonly CarDbContext dbContext;

        public DealerService(CarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Dealership> DeleteDealerById(Guid Id)
        {
            var dealer = dbContext.Dealer.FirstOrDefault(c => c.Id == Id);
            dbContext.Dealer.Remove(dealer);
            await dbContext.SaveChangesAsync();

            return dealer;
        }
        public async Task<IEnumerable<Dealership>> GetDealer()
        {
            return await dbContext.Dealer.ToListAsync();
        }
        public async Task<Dealership> GetDealerById(Guid Id)
        {
            return await dbContext.Dealer.SingleOrDefaultAsync(x => x.Id == Id);
        }
        public async Task PostDealer(CreateDealerDto createDealerDto)
        {
            var dealer = new Dealership
            {
                Id = Guid.NewGuid(),
                Name = createDealerDto.Name,
                Address = createDealerDto.Address,
                CarsId = createDealerDto.CarsId,
                CreatedDate = DateTime.UtcNow,
            };

            await dbContext.Dealer.AddAsync(dealer);
            await dbContext.SaveChangesAsync();
        }
        public Task<Dealership> PutDealer(Guid Id, UpdateDealerDto updateDealerDto)
        {
            throw new NotImplementedException();
        }
    }
}
