using System;
using System.Collections.Generic;
using System.IO;
using Senai.Revisao.MVC.ViewModel;

namespace Senai.Revisao.MVC.Repositorio
{
    public class UsuarioRepositorio
    {
        public static List<UsuarioViewModel> ListaDeUsuarios = new List<UsuarioViewModel>();

        public static UsuarioViewModel Inserir(UsuarioViewModel usuario)
        {
            List<UsuarioViewModel> listaDeUsuarios = Listar ();
           int contador = 0;
           if (listaDeUsuarios != null) {
               contador = listaDeUsuarios.Count;
           }
           usuario.Id = contador + 1;
            // Gera Arquivo CSV
            StreamWriter sw = new StreamWriter("usuarios.csv", true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao}");
            sw.Close();

            // ListaDeUsuarios.Add(sw);
            return usuario;
        }

        public static List<UsuarioViewModel> Listar()
        {
            UsuarioViewModel usuario;

            if (!File.Exists("usuarios.csv"))
            {
                return null;
            }

            string[] usuarios = File.ReadAllLines("usuarios.csv");

            foreach (var item in usuarios)
            {
                if (item != null)
                {
                    string[] dadosDoUsuario = item.Split(";");
                    usuario = new UsuarioViewModel();
                    usuario.Id = int.Parse(dadosDoUsuario[0]);
                    usuario.Nome = dadosDoUsuario[1];
                    usuario.Email = dadosDoUsuario[2];
                    usuario.Senha = dadosDoUsuario[3];
                    usuario.DataCriacao = DateTime.Parse(dadosDoUsuario[4]);
                    ListaDeUsuarios.Add(usuario);
                }
            }
            return ListaDeUsuarios;
        }

        public static UsuarioViewModel Login(string email, string senha)
        {
            foreach (UsuarioViewModel usuario in ListaDeUsuarios)
            {
                if (email.Equals(usuario.Email) && senha.Equals(usuario.Senha))
                {
                    return usuario;
                }
            }
            return null;
        }
    }
}