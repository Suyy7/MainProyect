using System;
using System.Xml.Linq;


namespace mainProyect
{
	public class DevValEEnergyMono: ValoresElecM
	{
        List<int> _dias = new List<int>();
        List<int> _Cons = new List<int>();
        int _limit = 30;
        public List<int> AddDays()// Adicionamos los dias a la lista
        {
           
           for (int i = 1 ; i <= _limit ; i++)
            { 
                if (_dias.Count < _limit) {_dias.Add(i); }
            
                    // Propiedad Add de adherir elemento
            }
           return _dias;
        }
        public List<int> AddconsumoP(List<int> dias) // Adhiere consumo de potencia Diaria
        {

           for(int i = 1; i<=_limit; i++){
                if (_Cons.Count < _limit)
                {
                    int element = potencia();
                    _Cons.Add(element); // Ahora puedo agregar potencia segun dias.
                }
           }
           return _Cons;
        }
        public int darPTM(List<int> lista) {
            
            int a = 0;
            foreach (int element in lista) {
                a +=element;
            }
            return a ;
        }  // 

        public int PotTotal(List<int> ints) { 
                    
            return ints.Count;
        }
        
        public int voltaje()
        {
            int minV = 217;
            int maxV = 227;
            return devolverAl(minV, maxV);
        }// Devuelvo el voltaje Monofiasico
        public int amperaje()
        { 
            int minA = 20;
            int maxA = 25;
            return devolverAl(minA, maxA);
        } // Devuelvo el amperaje 
        public int potencia()
        {
            int a = 0;
            int b = 5000;
            return devolverAl(a, b);
        }   // Devuelvo la potencia entre 0 y 5k
        public int devolverAl(int min, int max)
            {
            Random rand = new Random();
            return rand.Next(min, max);
            } // Base de nuevo 
    }
}