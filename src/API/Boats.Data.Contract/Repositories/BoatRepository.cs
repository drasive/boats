using Boats.Data.Contract.Entities;
using System.Linq;

namespace Boats.Data.Contract.Repositories
{
    public interface IBoatRepository
    {
        IQueryable<Boat> Get();
    }
}
