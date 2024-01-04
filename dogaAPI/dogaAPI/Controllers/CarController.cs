using dogaAPI.Models;
using dogaAPI.Models.Dtos;
using dogaAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dogaAPI.Controllers
{
    [Route("cars")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarInterface carService;

        public CarController(ICarInterface carService)
        {
            this.carService = carService;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateCarDto createCarDto)
        {
            await carService.PostCar(createCarDto);
            try
            {
                return StatusCode(201, "Sikeres hozzáadás.");
            }
            catch (Exception e)
            {

                return StatusCode(400, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cars>>> Get()
        {
            try
            {
                return StatusCode(200, await carService.Get());
            }
            catch (Exception e)
            {

                return StatusCode(400, e.Message);
            }
        }

        [HttpGet("{Id}")]
        public async Task<Cars> GetById(Guid Id)
        {
            return await carService.GetById(Id);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Cars>> DeleteById(Guid Id)
        {
            var result = await carService.DeleteById(Id);
            if (result == null)
            {
                return StatusCode(404, "Nincs ilyen rekord");
            }
            return StatusCode(200, result);
        }

    }
}
