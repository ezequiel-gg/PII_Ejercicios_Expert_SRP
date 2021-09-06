using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Sector sectorNuevo = new Sector("A");
            Estante estanteNuevo = new Estante("1");
            
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");

            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AlmacenarLibro(sectorNuevo, estanteNuevo, libro1);
            
        }
    }
}
