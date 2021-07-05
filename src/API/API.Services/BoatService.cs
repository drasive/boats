using Boats.API.Services.Contract;
using Boats.Data.Contract.Entities;
using Boats.Data.Contract.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Boats.Services
{
    public class BoatService : IBoatService
    {
        private readonly IBoatRepository _boatRepository;

        public BoatService(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }

        public Task<IQueryable<Boat>> GetAsync()
        {
            return Task.FromResult(_boatRepository.Get());
        }
    }
}
