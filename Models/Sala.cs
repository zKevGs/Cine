using Cine.Enums;

namespace Cine.Models
{
    public class Sala
    {  
        public int Numero { get; private set; }
        public List<Asiento> Asientos { get; private set; } = new List<Asiento>();        
        public Pelicula Pelicula { get; private set; }        
        public TimeOnly Horario {  get; private set; }

        public Sala(int numero)
        {
            Numero = numero;
            
        }
       
        public void AgregarAsiento(Asiento asiento)
        {
            Asientos.Add(asiento);
        }
        public void AgregarAsientos( List<Asiento> Asientos)
        {
            foreach (var Asi in Asientos)
            {
                Asientos.Add(Asi);
            }           
        }

        public void DefinirHorario(TimeOnly hora)
        {
            Horario = hora;
        }
        public void ReproducirPelicula(Pelicula pelicula)
        {
            Pelicula = pelicula;
        }
    }
}
