using Boats.Data.Contract.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Boats.Services.Contract
{
    public interface IBoatService
    {
        Task<IQueryable<Boat>> GetAsync();
    }
}
