using System;
using System.Collections.Generic;
using SRP;

namespace SRP
{
    public class Biblioteca
    {
        ///encargada de conocer la ubicacion de los libros en los diferentes sectores y estantes
        public List<Estante> Estantes { get; }

        private List<Sector> Sectores { get; }

        List<Ubicacion> Ubicaciones { get; set;}

        public Biblioteca()
        {
        }


        public void AlmacenarLibro(Sector sector, Estante estante, Libro libro)
        {
            Ubicacion ubicacion = new Ubicacion(sector,  estante, libro);
            this.Ubicaciones.Add(ubicacion);
        }

    }
}
