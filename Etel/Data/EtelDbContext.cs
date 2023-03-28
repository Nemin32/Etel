using Etel.Models;
using Microsoft.EntityFrameworkCore;

namespace Etel.Data
{
    public class EtelDbContext : DbContext
    {
        public DbSet<EtelClass> Foods { get; set; }
        public EtelDbContext(DbContextOptions<EtelDbContext> options) : base(options)
        {

        }
    }
}
