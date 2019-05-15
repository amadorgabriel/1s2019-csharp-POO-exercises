using System;
using System.Collections.Generic;
using System.IO;
using FinancaDeMesa.ViewModel;
using Spire.Doc;
using Spire.Doc.Documents;

namespace FinancaDeMesa.Repositorio
{
    public class UsuarioRepositorio
    {

        public static UsuarioViewModel InserirUsuario(UsuarioViewModel usuario)
        { //INSERE O USER NO CSV
            // adiciona o usuario a uma outra linha

            StreamWriter arquivoWritter = new StreamWriter("usuarios.csv", true);
            arquivoWritter.WriteLine($"{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNacimento};{usuario.Id}");
            arquivoWritter.Close();

            int contador = 0;
            if (TrazerListaDeUsuario() != null)
            {
                contador = TrazerListaDeUsuario().Count;
            }
            usuario.Id = contador + 1;

            return usuario;
        }
        public static List<UsuarioViewModel> TrazerListaDeUsuario()
        {//CADA USER É UMA LINHA;
            var ListaDeUsuarios = new List<UsuarioViewModel>();

            UsuarioViewModel usuario;
            string[] usuariosListados = File.ReadAllLines("usuarios.csv");

            if (!File.Exists("usuarios.csv"))
            {
                return null;
            }

            foreach (var item in usuariosListados)
            {
                if (item != null)
                {
                    string[] dadoUsuario = item.Split(";");
                    usuario = new UsuarioViewModel();
                    usuario.Nome = dadoUsuario[0];
                    usuario.Email = dadoUsuario[1];
                    usuario.Senha = dadoUsuario[2];
                    usuario.DataNacimento = DateTime.Parse(dadoUsuario[3]);
                    usuario.Id = int.Parse(dadoUsuario[4]);

                    ListaDeUsuarios.Add(usuario);
                }
            }
            return ListaDeUsuarios;
            //definir string de ususarios por linha será o STRING DE USUARIOS
            //definir string dos item de cada usuario será STRING ITENS USUARIOS
        }

        public static UsuarioViewModel TrazerUserLogado(string email, string senha)
        {
            List<UsuarioViewModel> ListaUsuarios = UsuarioRepositorio.TrazerListaDeUsuario();

            foreach (var item in ListaUsuarios)
            {
                if (email.Equals(item.Email) && senha.Equals(item.Senha))
                {
                    return item;
                }
            }
            return null;
        }

        public static Document GerarDocWord(){
            Document doc = new Document();
            Paragraph Para = doc.AddSection().AddParagraph();
            var ListaUser =  UsuarioRepositorio.TrazerListaDeUsuario();
            UsuarioViewModel usuario = new UsuarioViewModel();

            Para.AppendText("                                                          Relatório dos Usuários Cadastrados                                                  ");            
            foreach (var item in ListaUser)
            {
                Para.AppendText($"Nome: {item.Nome } - Id: {item.Id} - Email: {item.Email} - Data de Nacimento: {item.DataNacimento}");
            }
            doc.SaveToFile("ExtratoTransaçõesUsers.docx");
            return doc;
        }
    }
}