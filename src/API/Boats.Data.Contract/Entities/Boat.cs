using Boats.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Boats.Data.Contract.Entities
{
    public class Boat
    {
        public Guid Id { get; set; }

        [MaxLength(Constants.FieldLenghts.BoatName)]
        public string Name { get; set; }

        [MaxLength(Constants.FieldLenghts.BoatDescription)]
        public string Description { get; set; }
    }
}
