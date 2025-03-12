using System;
using System.ComponentModel.DataAnnotations;
// Vista
// Recibo los parametros del usuario
// Muestro los datos y agrego

namespace mainProyect
{
	public class ViewUsers : DevValEEnergyMono
	{
		public void ViewUs(List<DataUser> users) // F donde muestro los que tengo agregado
		{
			Console.WriteLine("Datos de usuarios: ");
			foreach (var user in users)
			{
				Console.WriteLine("ID: " + user.Id + " Name: " + user.Fullname + " Contract: " + user.Contract  + " Pais: " + user.Country + " Provincia: " + user.State + " Ciudad: " + user.City +" Numero de casa: " +  user.NumberHouse);
				Console.WriteLine ("- Sus datos de energia - ");
				Console.WriteLine ("Amp: " + user.Ahmp);
				Console.WriteLine ("Potencia: " + user.PowerW);
				Console.WriteLine ("Voltaje: " + user.Volts);
				
			}
		}


		public DataUser NewUser() // F. Pido los datos y los devuelvo.
		{  
			Console.WriteLine("Ingrese su numero de id: ");
			int uid = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese su nombre completo: ");
			string? uname = Console.ReadLine();
			Console.WriteLine("Ingrese su contrato: ");
			int ucnt = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese su pais: ");
			string? ctry = Console.ReadLine();
			Console.WriteLine("Ingrese su provincia: ");
			string? prv = Console.ReadLine();
			Console.WriteLine("Ingrese su ciudad: ");
			string? city = Console.ReadLine();
			Console.WriteLine("Ingrese el numero de casa: ");
			int numberHouse = int.Parse(Console.ReadLine());
			int pwr = potencia();
			int ahmp = amperaje();
			int vlts = voltaje();
			List<int> dias = AddDays();
			List<int> potD = AddconsumoP(dias);
			int ptm = darPTM(potD);
			int ptMP = ;
			return new DataUser
			{
				Id = uid,
				Fullname = uname,
				Contract = ucnt,
				State = prv,
				NumberHouse = numberHouse,
				City = city,
				PowerW = ptm,
				Volts = vlts,
				Ahmp = ahmp,
				Country = ctry,
				_dias = dias,
                _potenciDiaria = potD,
				_potenciPrecio = ptMP,
			};
		}
	}
}