using AutoMapper;
using Boats.Api.Dtos;
using Boats.Services.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boats.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoatController : ControllerBase
    {
        private readonly IBoatService _boatService;
        private readonly IMapper _mapper;

        public BoatController(IBoatService boatService, IMapper mapper)
        {
            _boatService = boatService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BoatDto>>> Get()
        {
            var boats = (await _boatService.GetAsync()).OrderBy(x => x.Name).ToList();
            var boatDTOs = _mapper.Map<IEnumerable<BoatDto>>(boats);

            return Ok(boatDTOs);
        }
    }
}
