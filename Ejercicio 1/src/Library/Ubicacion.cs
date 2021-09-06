
namespace SRP
{
    public class Ubicacion
    {
        Sector Sector { get ;   set; }
        Estante Estante  { get ;  set; }
        Libro Libro { get ;  set; }

        public Ubicacion(Sector sector, Estante estante, Libro libro)
        {
            this.Libro = libro;
            this.Sector = sector;
            this.Estante = estante;
        }
    }
}
