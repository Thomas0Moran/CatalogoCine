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
            Console.WriteLine("");

            Console.WriteLine("Indique la opción deseada:");
            Console.WriteLine("1-Crear nueva region");
            Console.WriteLine("2-Actualizar una region");
            Console.WriteLine("3-Borrar region");
            Console.WriteLine("4-Obtener territorios de una region");
            Console.WriteLine();
            Console.WriteLine("Ingrese la opcion seleccionada:");
            string opcion = Console.ReadLine();
            switch(opcion.ToUpper().Trim())
            {
                case "1":
                    CrearNuevaRegion();
                    break;
                case "2":
                    ActualizarRegion();
                    break;
                case "3":
                    BorrarRegion();
                    break;
                case "4":
                    ListarTerritorios();
                    break;
            }

        }

        private void ListarTerritorios()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el identificador de la region:");

            string idIngresando = Console.ReadLine();
            int id = Convert.ToInt32(idIngresando);
            Region region = dataAccess.ObtenerRegion(id);
            if (region == null)
            {
                Console.WriteLine("No ingreso el ID de una region existente");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Territorios de {region.RegionID}-{region.RegionDescription}");
                List<Territory> territorios = region.Territories.ToList();
                foreach(var territorio in territorios)
                {
                    Console.WriteLine($"Territorio: {territorio.TerritoryID}-{territorio.TerritoryDescription}");
                }
            }
        }

        private void BorrarRegion()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el identificador de la region que desee borrar:");

            string idIngresando = Console.ReadLine();
            int id = Convert.ToInt32(idIngresando);

            Region regionAActualzar = dataAccess.ObtenerRegion(id);
            if (regionAActualzar == null)
            {
                Console.WriteLine("No ingreso el ID de una region existente");
            }
            else
            {
                dataAccess.BorrarRegion(id);
            }
        }

        private void ActualizarRegion()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el identificador de la region que desee actualizar:");

            string idIngresando = Console.ReadLine();
            int id = Convert.ToInt32(idIngresando);

            Region regionAActualzar = dataAccess.ObtenerRegion(id);
            if(regionAActualzar == null)
            {
                Console.WriteLine("No ingreso el ID de una region existente");
            }
            else
            {
                Console.WriteLine($"La region a actualizar es: {regionAActualzar.RegionID}-{regionAActualzar.RegionDescription}");
                Console.WriteLine();
                string nombre = Console.ReadLine();
                dataAccess.ActualizarRegion(id, nombre);
            }

        }

        private void CrearNuevaRegion()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el nombre de la nueva region");
            string nombre = Console.ReadLine();
            dataAccess.CrearNuevaRegion(nombre.Trim());
        }


    }
}
