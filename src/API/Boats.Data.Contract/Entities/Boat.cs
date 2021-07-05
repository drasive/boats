using System;

namespace Boats.Data.Contract.Entities
{
    public class Boat
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
