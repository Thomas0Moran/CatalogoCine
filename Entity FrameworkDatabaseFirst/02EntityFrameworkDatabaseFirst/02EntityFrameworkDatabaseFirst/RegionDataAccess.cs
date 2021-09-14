using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EntityFrameworkDatabaseFirst
{
    class RegionDataAccess
    {
        NorthwindEntities entidades = new NorthwindEntities();
        public List<Region> ObtenerTodasLasRegiones()
        {
            //var query = from e in entidades.Regions
            //          select e;

            var query = entidades.Regions;

            return query.ToList();
        }
    }
}
