using AutoMapper.Configuration;
using Boats.API.DTOs;
using Boats.Data.Contract.Entities;

namespace Boats.API.Mapping
{
    public class BoatProfile : MapperConfigurationExpression
    {
        public BoatProfile()
        {
            CreateMap<Boat, BoatDTO>();
        }
    }
}
