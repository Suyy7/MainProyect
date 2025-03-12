using System;
namespace mainProyect
{
    public class DevValEEnergyBifa : ValoresElec
    {
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