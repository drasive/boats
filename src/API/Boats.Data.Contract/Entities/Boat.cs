using Boats.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Boats.Data.Contract.Entities
{
    public class Boat
    {
        // Parameterless constructor for ORM 
        private Boat() { }

        public Boat(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Guid Id { get; set; }

        [MaxLength(Constants.FieldLenghts.BoatName)]
        public string Name { get; set; }

        [MaxLength(Constants.FieldLenghts.BoatDescription)]
        public string Description { get; set; }
    }
}
