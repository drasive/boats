using Boats.Data.Contract.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Boats.Data
{
    public static class Seeder
    {
        public static async Task EnsureSeededAsync(BoatsContext boatsContext, int boatCount)
        {
            if (!boatsContext.Boats.Any())
            {
                for (int i = 0; i < boatCount; i++)
                {
                    var numberString = i + 1 < 10
                        ? $"0{i + 1}"
                        : $"{i + 1}";
                    var boat = new Boat($"Boat {numberString}", string.Empty);
                    boatsContext.Add(boat);
                }

                await boatsContext.SaveChangesAsync();
            }
        }
    }
}
