
using Cine.Enums;

namespace Cine.Models
{
    public class Entrada
    {
        public Cine Cine { get; private set; }
        public Pelicula Pelicula { get; private set; }
        public Asiento Asiento { get; private set; }
        public double PrecioBase { get; private set; }
        public DateTime Fecha { get; private set; }

        public double PrecioFinal
        {
            get
            {
                double precioFinal = PrecioBase;
 
                if (Asiento.Tipo == TiposDeAsientos.Superseat)
                {
                    precioFinal += 500; 
                }
                switch (Pelicula.Formato)
                {
                    case Formatos._3D_Doblada:
                    case Formatos._3D_Subtitulada:
                        precioFinal += 300; 
                        break;
                    case Formatos.IMAX_Doblada:
                    case Formatos.IMAX_Subtitulada:
                        precioFinal += 700; 
                        break;
                }
                return precioFinal;
            }
        }

        public Entrada (Cine cine, Pelicula pelicula, Asiento asiento, double precioBase, DateTime fecha)
        {
            Cine = cine;
            Pelicula = pelicula;
            Asiento = asiento;
            PrecioBase = precioBase;
            Fecha = fecha;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine("═════════════════════════════════════════════════════");
            Console.WriteLine($"Cine: \n{Cine.Nombre}");
            Console.WriteLine("═════════════════════════════════════════════════════");
            Console.WriteLine($"Película: \n{Pelicula.Nombre}");
            Console.WriteLine($"Género: \n{Pelicula.Genero}");
            Console.WriteLine($"Duración: \n{Pelicula.Duracion} minutos");
            Console.WriteLine($"Formato: \n{Pelicula.Formato}");
            Console.WriteLine("═════════════════════════════════════════════════════");
            Console.WriteLine($"Asiento: \n{Asiento.Letra}{Asiento.Numero}");
            Console.WriteLine($"Tipo: \n{Asiento.Tipo}");
            Console.WriteLine($"Precio Base: \n${PrecioBase:F2}");
            Console.WriteLine($"Precio Final: \n${PrecioFinal:F2}");
            Console.WriteLine("═════════════════════════════════════════════════════");
            Console.WriteLine($"Fecha: \n{Fecha}");
            Console.WriteLine("═════════════════════════════════════════════════════");
        }

    }
}
