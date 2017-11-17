using LicensePlates.Entities;
using LicensePlates.Models;
using System.Collections.Generic;
using System.Linq;

namespace LicensePlates.Repositories
{
    public class LicensePlatesRepository
    {
        LicensePlatesContext LicensePlatesContext;

        public LicensePlatesRepository(LicensePlatesContext licensePlatesContext)
        {
            LicensePlatesContext = licensePlatesContext;
        }

        public List<LicensePlate> ListPosts()
        {
            return LicensePlatesContext.LicensePlates.ToList();
        }
    }
}
