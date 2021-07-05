using Boats.API.Services.Contract;
using Boats.Data.Contract.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boats.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoatController : ControllerBase
    {
        private readonly IBoatService _boatService;

        public BoatController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Boat>>> Get()
        {
            var boats = await _boatService.GetAsync();
            return Ok(boats);
        }
    }
}
