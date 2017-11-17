using title.Entities;
using title.Models;
using System.Collections.Generic;
using System.Linq;

namespace title.Repositories
{
    public class LicensePlatesRepository
    {
        LicensePlatesContext LicensePlatesContext;

        public LicensePlatesRepository(LicensePlatesContext licensePlatesContext)
        {
            LicensePlatesContext = licensePlatesContext;
        }

        public List<LicensePlate> GetList()
        {
            return LicensePlatesContext.LicensePlates.ToList();
        }

        public List<LicensePlate> PoliceCars()
        {
            var policeCars = from LicensePlate in LicensePlatesContext.LicensePlates
                             where LicensePlate.Plate.StartsWith = "RB"
                             select LicensePlate;
        }

        public List<LicensePlate> DiplomatCars()
        {
            var diplomatCars = from LicensePlate in LicensePlatesContext.LicensePlates
                               where LicensePlate.Plate.StartsWith = "DT"
                               select LicensePlate;
        }


    }
}
