using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;



namespace DatoElectrico
{
    public class DevolverAmpM : DatosElectricos {
        protected int devolverAl(int min, int max) // Devolvemos num aleatorio segun parametros
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
        public int amperaje()
        {
            return devolverAl(this.Min, this.Max);
        }  // Funcion que retorna amperaje
        public int Min = 10;
        public int Max = 25;
        public void GetAmp() // Funcion para mostrar amperaje en consola
        {
            Console.WriteLine("El amperaje es: " + amperaje());
        }


    }
    public class DevolverVoltM : DatosElectricos {
        
        protected int devolverAl(int min, int max) // Devolvemos num aleatorio 
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
        public int voltajeM()
        {
            return devolverAl(this.Min, this.Max);
        }  // Funcion que retorna voltaje
        public int Min = 217;
        public int Max = 230;

        
        public void GetVolt() {
            
            Console.WriteLine("El voltaje es: " + voltajeM());
        }// Funcion para mostrar voltaje en consola


    }
    public class DevolverPowM : DatosElectricos {

        public int Amp { get; set; } 
        public int Vlt { get; set; }

        public DevolverPowM(int _min, int _max) {
            Amp = _min;
            Vlt = _max;
        }
        public int potencia()
        {
            return Amp * Vlt;
        }
        public void GetPow()
        {
            Console.WriteLine("La potencia es: " + potencia());
        }// Funcion para mostrar potencia en consola
    }
    









}