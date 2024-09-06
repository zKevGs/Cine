

namespace Cine.Models
{
    public class Cine
    {
        public string Nombre { get; private set; }
        public List<Sala> Sala { get; private set; } = new List<Sala> ();

        public Cine(string nombre)
        {
            Nombre = nombre;
        }
        public void AgregarSala(Sala sala)
        {
            Sala.Add(sala);   
        }

    }
}
