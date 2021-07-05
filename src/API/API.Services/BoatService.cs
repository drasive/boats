using Boats.API.Services.Contract;
using Boats.Data.Contract.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Boats.Services
{
    public class BoatService : IBoatService
    {
        public Task<IQueryable<Boat>> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
