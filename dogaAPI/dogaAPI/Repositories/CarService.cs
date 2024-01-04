using dogaAPI.Models;
using dogaAPI.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace dogaAPI.Repositories
{
    public class CarService : ICarInterface
    {
        public readonly CarDbContext dbContext;

        public CarService(CarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Cars> DeleteById(Guid Id)
        {
            var car = dbContext.Car.FirstOrDefault(c => c.Id == Id);
            dbContext.Car.Remove(car);
            await dbContext.SaveChangesAsync();

            return car;
        }
        public async Task<IEnumerable<Cars>> Get()
        {
            return await dbContext.Car.ToListAsync();
        }
        public async Task<Cars> GetById(Guid Id)
        {
            return await dbContext.Car.SingleOrDefaultAsync(x => x.Id == Id);
        }
        public async Task PostCar(CreateCarDto createCarDto)
        {
            var car = new Cars
            {
                Id = Guid.NewGuid(),
                Brand = createCarDto.Brand,
                Model = createCarDto.Model,
                CreatedDate = DateTime.UtcNow,
            };

            await dbContext.Car.AddAsync(car);
            await dbContext.SaveChangesAsync();
        }
        public Task<Cars> PutCar(Guid Id, UpdateCarDto updateCarDto)
        {
            throw new NotImplementedException();
        }
    }
}
