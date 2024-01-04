using dogaAPI.Models.Dtos;
using dogaAPI.Models;
using dogaAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dogaAPI.Controllers
{
    [Route("dealers")]
    [ApiController]
    public class DealerController : ControllerBase
    {
        private readonly IDealerInterface dealerService;

        public DealerController(IDealerInterface dealerService)
        {
            this.dealerService = dealerService;
        }

        [HttpPost]
        public async Task<ActionResult> PostDealer(CreateDealerDto createDealerDto)
        {
            await dealerService.PostDealer(createDealerDto);
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
        public async Task<ActionResult<IEnumerable<Dealership>>> GetDealer()
        {
            try
            {
                return StatusCode(200, await dealerService.GetDealer());
            }
            catch (Exception e)
            {

                return StatusCode(400, e.Message);
            }
        }

        [HttpGet("{Id}")]
        public async Task<Dealership> GetDealerById(Guid Id)
        {
            return await dealerService.GetDealerById(Id);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Dealership>> DeleteDealerById(Guid Id)
        {
            var result = await dealerService.DeleteDealerById(Id);
            if (result == null)
            {
                return StatusCode(404, "Nincs ilyen rekord");
            }
            return StatusCode(200, result);
        }
    }
}
