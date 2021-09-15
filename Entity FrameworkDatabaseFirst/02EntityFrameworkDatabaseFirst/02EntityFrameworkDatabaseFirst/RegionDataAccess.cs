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

        internal void CrearNuevaRegion(string descripcion)
        {
            int id = IdMaximo();
            id++;

            Region region = new Region()
            {
                RegionID = id,
                RegionDescription = descripcion
            };

            entidades.Regions.Add(region);
            entidades.SaveChanges();
        }

        private int IdMaximo()
        {
            int id = entidades.Regions.Max(r => r.RegionID);
            return id;
        }
    }
}
