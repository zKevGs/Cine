using Cine.Enums;

namespace Cine.Models
{
class Program
{
        public static void Main(string[] args)
        {

            Cine cine = new Cine("Cineplex");
            Sala sala = new Sala(1);
            Pelicula pelicula = new Pelicula("Inception", "Ciencia Ficción", 148, Formatos.IMAX_Subtitulada);
            Asiento asiento1 = new Asiento('A', 1, TiposDeAsientos.Superseat);

            sala.AgregarAsiento(asiento1);
            sala.ReproducirPelicula(pelicula);
            cine.AgregarSala(sala);

            Entrada entrada = new Entrada(cine, pelicula, asiento1, 8000, DateTime.Now);
            entrada.MostrarDetalles();
        }
    }
}

