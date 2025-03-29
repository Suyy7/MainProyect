using System; 
using mainProyect;

namespace DatoElectrico
{
    interface DatosElectricos
    {
         int voltajeMin { get; set; }
         int voltajeMax = 220;
         int amperajeMin = 0;
         int amperajeMax = 999;
         int potenciaMin = 0;
         int potenciaMax = 999999;
    }
    public class DevolverDatoElectrico : DatosElectricos
    {
        public voltajeMin; 


        public int devolverAl(int min, int max)
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
        public int potencia()
        {
            int a = 0;
            int b = 5000;
            return devolverAl(a, b);
        }
    }
}
