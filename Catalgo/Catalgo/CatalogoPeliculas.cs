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

            Peliculas.Add(new Pelicula()
            {
                Id = 7,
                Titulo = "Avengers Infinity War",
                Año = 2018,
                Director = "JoeYAnthonyRusso",
                Clasico = false,
                Genero = null //ciencia ficcion
            });
        }

        public IEnumerable<Pelicula> ObtenerPorAño(int año)
        {
            return Peliculas
                .Where(peli => peli.Año == año)
                .OrderBy(peli => peli.Titulo);
        }

        public IEnumerable<Pelicula> ObtenerPorAñoConsulta(int año)
        {
            return from p in Peliculas
                   where p.Año == año
                   orderby p.Titulo
                   select p;

        }

        public IEnumerable<Pelicula> ObtenerPorGenero(int genero)
        {
            return Peliculas
                //.Where(peli =>peli.Genero!=null && peli.Genero.Id == genero)
                .Where(peli => peli.Genero?.Id == genero)
                .OrderBy(peli => peli.Titulo);
        }

        public IEnumerable<Pelicula>BuscarPorTitulo(string busqueda)
        {
            return Peliculas
                .Where(peli => peli.Titulo.ToUpper().Contains(busqueda.ToUpper()))
                .OrderBy(peli => peli.Titulo);
        }

        public void MostrarTodasLasPeliculas()
        {
            var resultado= from p in Peliculas
                   orderby p.Titulo
                   select new { p.Titulo, p.Año };

            foreach (var item in resultado)
            {
                Console.WriteLine($"Titulo: {item.Titulo}, Año: {item.Año}");
            }
        }


    }
}
