using Microsoft.EntityFrameworkCore;
using LicensePlates.Models;

namespace LicensePlates.Entities
{

    public class LicensePlatesContext : DbContext
    {
        public LicensePlatesContext(DbContextOptions<LicensePlatesContext> options) : base(options)
        {

        }

        public DbSet<LicensePlate> LicensePlates { get; set; }
    }
}