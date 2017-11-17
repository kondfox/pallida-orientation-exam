using Microsoft.EntityFrameworkCore;
using title.Models;

namespace title.Entities
{

    public class LicensePlatesContext : DbContext
    {
        public LicensePlatesContext(DbContextOptions<LicensePlatesContext> options) : base(options)
        {

        }

        public DbSet<LicensePlate> LicensePlates { get; set; }
    }
}