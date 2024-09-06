

using Cine.Enums;

namespace Cine.Models
{
    public class Asiento
    {
        
        public char Letra { get; private set; }
        public int Numero { get; private set; }
        public TiposDeAsientos Tipo { get; private set; }
        public bool Ocupado { get; private set; }

        public Asiento(char letra, int numero, TiposDeAsientos tipo) 
        {
            Letra = letra;
            Numero = numero;
            Tipo = tipo;
            Ocupado = false;
        }

        public void CambiarOcupado()
        {
            Ocupado = !Ocupado;
        }
    }
}
