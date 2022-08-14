using System;
using System.Collections.Generic;
using ToDo_List.ViewModel;

namespace ToDo_List.Repositorio
{
    public class UsuarioRepositorio
    {
        static List<UsuarioViewModel> ListaDeUsers = new List<UsuarioViewModel>();
        //----------------------------------------------------------
        public static UsuarioViewModel Inserir(UsuarioViewModel user)
        {
            ListaDeUsers.Add(user);
            return user;
        }

        public static List<UsuarioViewModel> Listar()
        {
            return ListaDeUsers;
        }
    }
}