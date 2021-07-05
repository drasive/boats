using AutoMapper.Configuration;
using Boats.Api.Dtos;
using Boats.Data.Contract.Entities;

namespace Boats.Api.Mapping
{
    public class BoatProfile : MapperConfigurationExpression
    {
        public BoatProfile()
        {
            CreateMap<Boat, BoatDto>();
        }
    }
}
