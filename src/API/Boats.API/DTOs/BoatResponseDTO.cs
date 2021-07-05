using System;

namespace Boats.API.DTOs
{
    public class BoatResponseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
