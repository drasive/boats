using Boats.Data.Contract.Entities;
using Microsoft.EntityFrameworkCore;

namespace Boats.Data
{
    public class BoatsContext : DbContext
    {
        public BoatsContext(DbContextOptions<BoatsContext> options)
            : base(options)
        { }

        public DbSet<Boat> Boats { get; set; }
    }
}
