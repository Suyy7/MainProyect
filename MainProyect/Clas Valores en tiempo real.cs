using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

// *** Recordar que esto es un programa para simular datos que envia un dispositivo. ****


// Lista de elementos

// -------------------------------- Class -------------------------------------------//
namespace mainProyect
{
    public class ListDeCalculosE<T> : ValoresElec
        { // Esta es la clase
            private int devolverAl(int min, int max)
            {
            Random rand = new Random();
            return rand.Next(min, max);
            }
            private int voltaje(int minV, int maxV)
            {
            return devolverAl(minV, maxV);
            }
            private int amperaje(int minA, int maxA)
            {
            return devolverAl(minA, maxA);
            }
            private int potencia()
            {
            int a = 0;
            int b = 5000;
            return devolverAl(a, b);
            }



            private List<T> _dias; // Esto es un objeto de tipo lista donde vamos a alojar los DIAS
            private List<int> _Cons; // Esto es un objeto de tipo lista donde vamos a alojar los elementos
            private int _limit;  // Este es el limite de elementos que vamos a recibir

            public ListDeCalculosE(int limit)
            { // Constructor

                _limit = limit;  // Le inicalizamos la variable del limite
                _dias = new List<T>(); // Creamos el objeto en el constructor
                _Cons = new List<int>();
            }

            public void AddDays(T element)// Adicionamos los dias a la lista
            {
            for (int i = 0; i <= _limit; i++ ) {
                if (_dias.Count < _limit)
                    {
                    _dias.Add(element);    // Propiedad Add de adherir elemento
                    } 
                }
            }
            public void AddconsumoP() // Adhiere consumo de potencia Diaria
            {  
                if (_Cons.Count < _limit)
                {
                    int element = potencia();
                    _Cons.Add(element); // Ahora puedo agregar potencia segun dias.
                }
            }
            // ----------------------------------------------- // 
            public void PrecioSegunDias() {
                int a = 0;
                int ab = 0;
                foreach (int element in _Cons) {
                   
                a +=element;
                }
                ab = (a / 1000) * 101;
            Console.WriteLine("Total consumido: " + a);
            Console.WriteLine("Precio de la potencia consumida: " + ab);
            }
            // ----------------------------------------------- // 
            public void mostrarD() // Mostramos dias
            {
            string content = " ";
                foreach (T elementos in _dias) // Iteramos sobre la lista en si
                {
                    content = content + " " +elementos;
                    
                   
                }
                Console.WriteLine("Dias: " + content);
            }
            public void mostrarPD() // Mostrar Potencia Diaria
            { 
                foreach (int elementos in _Cons) // Iteramos sobre la lista en si
                {
                    Console.WriteLine(elementos);  // Mostramos los elementos de la lista de potencia
                }
            }
            
    }
       
        // Clase padre que da metodos
        // Esta clase genera el numero aleatorio.
        public interface ValoresElec 
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