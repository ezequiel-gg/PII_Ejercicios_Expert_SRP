using System;

namespace SRP
{   
    /// <summary>
    /// En aspectos generales, no se respeta el principio SRP, debido a que esta clase Libro, contiene varias responsabilides, 
    /// y por ende varias razones de cambio. Seria mas conveniente que sea la bliblioteca la que se encargue del almacenamiento del mismi
    /// 
    /// </summary>
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            /// <summary>
            /// este metodo seria mejor asignarlo a una clase Biblioteca, ya que por ejemplo en caso de agregar un estante
            /// implica una razon de cambio en la clase libro
            /// </summary>
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
