using System;
using System.Collections.Generic;
using System.IO;
using FinancaDeMesa.ViewModel;

namespace FinancaDeMesa.Repositorio
{
    public class UsuarioRepositorio
    {
        //Criar lista de Usuarios com csv
        public static UsuarioViewModel InserirUsuario(UsuarioViewModel usuario){
            //cria um csv
            //adiciona o usuario a uma outra linha
            
            StreamWriter arquivoWritter = new StreamWriter("usuarios.csv", true);
            arquivoWritter.WriteLine($" Nome {usuario.Nome} - Email {usuario.Email} - Data Criação {usuario.DataCriacao} ")
            arquivoWritter.Close();  

            return usuario;          

        }

        //return uruario
        public static List<UsuarioViewModel> TrazerListaDeUsuario(){
            var listaDeUsuarios = new List<UsuarioViewModel>() ; //LISTA QUALQUER;
            return listaDeUsuarios;









            //definir string de ususarios por linha será o STRING DE USUARIOS
            //definir string dos item de cada usuario será STRING ITENS USUARIOS
            //return ListaDeUsuarios 

        }
   
   
   
   
   
   
    }
} 