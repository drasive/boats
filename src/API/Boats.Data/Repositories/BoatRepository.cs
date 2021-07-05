using Boats.Data.Contract.Entities;
using Boats.Data.Contract.Repositories;
using System;
using System.Linq;

namespace Boats.Data.Repositories
{
    public class BoatRepository : IBoatRepository
    {
        public IQueryable<Boat> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
