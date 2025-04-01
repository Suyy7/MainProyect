using MainProyect.Vista;
using System;
using System.Linq.Expressions;



namespace mainProyect
{
    public class UserController
    {
        public Users _user;
        public ViewUsers _viewUsers;

        public UserController(Users dataUser, ViewUsers viewUsers)
        {
            _user = dataUser;
            _viewUsers = viewUsers;
        }
        // ----------------------------------------------- //


        public void AgregarUs() // Agregamos los user
        {
            DataUser users = _viewUsers.NewUser();
            _user.AddUs(users);

        }
        public void MostrarUsers() // Mostramos los user
        {
            List<DataUser> dataUsers = _user.ObtainUsers();
            _viewUsers.ViewUs(dataUsers);
        }


    }
}