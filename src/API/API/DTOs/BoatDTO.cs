﻿using System;

namespace Boats.API.DTOs
{
    public class BoatDTO
    {
        public class Boat
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
}
