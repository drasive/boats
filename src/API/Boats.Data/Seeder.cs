using Boats.Data.Contract.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Boats.Data
{
    public static class Seeder
    {
        public static async Task EnsureSeededAsync(BoatsContext boatsContext)
        {
            if (!boatsContext.Boats.Any())
            {
                for (int i = 0; i < 50; i++)
                {
                    var boat = new Boat($"Boat {i + 1}", string.Empty);
                    boatsContext.Add(boat);
                }

                await boatsContext.SaveChangesAsync();
            }
        }
    }
}
