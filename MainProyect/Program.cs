using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using DatoElectrico;


namespace mainProyect
{
    
    class Program 
    {
        static void Main(string[] args)
        {
           var ampp = new DevolverAmpM();
           ampp.GetAmp();
           var voltt = new DevolverVoltM();
           voltt.GetVolt();

        }
        

    }
}