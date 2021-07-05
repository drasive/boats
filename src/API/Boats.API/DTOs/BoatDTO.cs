using System;

namespace Boats.Api.DTOs
{
    public class BoatDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
