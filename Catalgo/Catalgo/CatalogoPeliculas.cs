using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalgo
{
    class CatalogoPeliculas
    {
        public List<Pelicula> Peliculas { get; set; }

        public CatalogoPeliculas()
        {
            Peliculas = new List<Pelicula>();
            IniciarlizarListaPeliculas();

        }

        private void IniciarlizarListaPeliculas()
        {
            Genero Terror = new Genero()
            {
                Id = 1,
                Nombre = "Terror"
            };

            Genero Comedia = new Genero()
            {
                Id = 2,
                Nombre="Comedia"
            };

            Genero CienciaFiccion = new Genero()
            {
                Id = 3,
                Nombre = "Ciencia Ficcion"
            };

            Genero Animacion = new Genero()
            {
                Id = 4,
                Nombre = "Animacion"
            };

            Genero Accion = new Genero()
            {
                Id = 5,
                Nombre = "Accion"
            };

            Peliculas.Add(new Pelicula()
            {
                Id=1,
                Titulo="Avengers EndGame",
                Año=2019,
                Director= "JoeYAnthonyRusso",
                Clasico= false,
                Genero= CienciaFiccion
            });

            Peliculas.Add(new Pelicula()
            {
                Id = 2,
                Titulo = "ToyStory",
                Año = 1995,
                Director = "John Lasseter",
                Clasico = true,
                Genero = Animacion
            });

            Peliculas.Add(new Pelicula()
            {
                Id = 3,
                Titulo = "E.T.",
                Año = 1982,
                Director = "Steven Spielberg",
                Clasico = true,
                Genero = CienciaFiccion
            });

            Peliculas.Add(new Pelicula()
            {
                Id = 4,
                Titulo = "Friday the 13th",
                Año = 1980,
                Director = "Sean G. Cunningham",
                Clasico = true,
                Genero = Terror
            });

            Peliculas.Add(new Pelicula()
            {
                Id = 5,
                Titulo = "Mission Impossible",
                Año = 1996,
                Director = "Brian De Palma",
                Clasico = false,
                Genero = Accion
            });

            Peliculas.Add(new Pelicula()
            {
                Id = 6,
                Titulo = "White Chicks",
                Año = 2004,
                Director = "Keenen Ivory Wayans",
                Clasico = false,
                Genero = Comedia
            });
        }

        public IEnumerable<Pelicula> ObtenerPorAño(int año)
        {
            return Peliculas.Where(peli => peli.Año == año);
        }
    }
}
