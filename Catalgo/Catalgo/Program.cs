using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese el año para buscar en el catalogo de peliculas");
            string ingresoAño = Console.ReadLine();
            int año=0;

            try
            {
                año = Convert.ToInt32(ingresoAño);
            }
            catch
            {
                año = 0;
            }

            CatalogoPeliculas miCatalog = new CatalogoPeliculas();

            var listaPeliculas = miCatalog.ObtenerPorAño(año);

            Console.WriteLine("Listado de peliculas por año");
            foreach (var pelicula in listaPeliculas)
            {
                Console.WriteLine($"Titulo:{pelicula.Titulo},Año {pelicula.Año}");
            }

            Console.ReadKey();
        }
    }
}
