using System;

// Model
namespace mainProyect {

    
    public class DataUser  // Objeto DataUser
    {
        public required int Id { get; set; }
        public required string? Fullname { get; set; }
        public required int Contract { get; set;  }

        // ------------------------------------------ // 
        public required int? NumberHouse { get; set;  }
        public required string? State { get; set; }
        public required string? City  { get; set; }
        public required string? Country { get; set; }

        // ----------------------------------------- // 

        public required int PowerW { get; set; }
        public required int Volts { get; set; }
        public required int Ahmp { get; set; }

        // ---------------------------------------- // 
 
        public List<int>? _dias;
        public List<int>? _potenciDiaria;
        public int? _potenciPrecio;
        
        
        

        
    }
    public class Users  // Lista para agendar a los usuarios
    {
        public List<DataUser> users = new();  // users es la lista donde voy a guardar a los user 

        public void AddUs(DataUser user) // Funcion void donde guardo todos los users
        {
            users.Add(user);    
            
        }

        public List<DataUser> ObtainUsers()  // Obtengo los usuarios 
        { 
        return users; 
        }


    }


}
