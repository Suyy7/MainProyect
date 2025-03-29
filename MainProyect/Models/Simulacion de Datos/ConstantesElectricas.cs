using System; 
using mainProyect;

namespace DatoElectrico
{
    interface DatosElectricos // Interface para funciones constantes
    {
        public int devolverAl(int min, int max) // Devolvemos num aleatorio segun parametros
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
        public int voltaje(int minV, int maxV)
        {
            return devolverAl(minV, maxV);
        }
        public int amperaje(int minA, int maxA)
        {
            return devolverAl(minA, maxA);
        }
        public int potencia(int a, int b)
        {
            return a * b;
        }
    }
}
