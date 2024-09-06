

using Cine.Enums;

namespace Cine.Models
{
    public class Pelicula
    {
        public string Nombre { get; private set; }
       
        public string Genero { get; private set; }
       
        public int Duracion {  get; private set; }
        
        public Formatos Formato { get; private set; }

        public Pelicula(string nombre, string genero, int duracion, Formatos formato)
        {
            Nombre = nombre;
            Genero = genero;
            Duracion = duracion;
            Formato = formato;
        }

        
        

    }
}
