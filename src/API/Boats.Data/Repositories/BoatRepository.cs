using Boats.Data.Contract.Entities;
using Boats.Data.Contract.Repositories;
using System.Linq;

namespace Boats.Data.Repositories
{
    public class BoatRepository : IBoatRepository
    {
        private readonly BoatsContext _boatsContext;

        public BoatRepository(BoatsContext boatsContext)
        {
            _boatsContext = boatsContext;
        }

        public IQueryable<Boat> Get()
        {
            return _boatsContext.Boats;
        }
    }
}
