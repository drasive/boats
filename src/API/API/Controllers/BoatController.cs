using AutoMapper;
using Boats.API.DTOs;
using Boats.API.Services.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boats.API.Controllers
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
        public async Task<ActionResult<IEnumerable<BoatResponseDTO>>> Get()
        {
            var boats = (await _boatService.GetAsync()).OrderBy(x => x.Name).ToList();
            var boatDTOs = _mapper.Map<IEnumerable<BoatResponseDTO>>(boats);

            return Ok(boatDTOs);
        }
    }
}
