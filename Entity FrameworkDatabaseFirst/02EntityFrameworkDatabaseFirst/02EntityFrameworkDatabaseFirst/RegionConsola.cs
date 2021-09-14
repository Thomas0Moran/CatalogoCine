using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EntityFrameworkDatabaseFirst
{
    class RegionConsola
    {
        RegionDataAccess dataAccess = new RegionDataAccess();
        public void MostrarRegiones()
        {
            List<Region> regiones = dataAccess.ObtenerTodasLasRegiones();
            foreach (var region in regiones)
            {
                Console.WriteLine($"{region.RegionID}-{ region.RegionDescription}");               
            }

        }
    }
}
