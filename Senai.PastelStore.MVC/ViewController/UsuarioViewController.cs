using System;
using System.Threading;
using System.Collections.Generic;
using Senai.PastelStore.MVC.Repositorio;
using Senai.PastelStore.MVC.Utils;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC.ViewController
{
    public class UsuarioViewController
    {
        //Instanciar o repositório
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public static void CadastrarUsuario()
        {

            string nome, email, senha, confirmaSenha;

            do
            { //DIGITAR NOME
            Console.Clear();
            
                System.Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome)) // MÉTODO PRÓPRIO PARA ANALIDAR STRINGS
                {
                    System.Console.WriteLine("Nome Inválido!");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            { //DIGITAR EMAIL
            
                System.Console.Write("Digite seu email: ");
                email = Console.ReadLine();
                if (!ValidacoesUtil.ValidadorDeEmail(email))
                {
                    System.Console.WriteLine("Email inválido");
                }
            } while (!ValidacoesUtil.ValidadorDeEmail(email));

            do
            { //DIGITAR SENHA 2 VEZES
            
                System.Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();

                System.Console.Write("Confirme a senha: ");
                confirmaSenha = Console.ReadLine();

                if (!ValidacoesUtil.ValidadorDeSenha(senha, confirmaSenha))
                {
                    System.Console.WriteLine("Senha Inválida");
                }

            } while (!ValidacoesUtil.ValidadorDeSenha(senha, confirmaSenha));

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;



            usuarioRepositorio.Inserir(usuarioViewModel);
            System.Console.WriteLine("Usuário Cadastrado com sucesso!");

        }//FIM CADASTRO
    
        public static void ListarUsuario(){
            
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

            foreach (var item in listaDeUsuarios)
            {
                System.Console.WriteLine($"Id: {item.Id} \nNome: {item.Nome}\nEmail: {item.Email}\nSenha: {item.Senha}\nData Criação: {item.DataCriacao} ");
                System.Console.WriteLine(" ");
            }   
        }//FIM LISTAR USUARIO

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;

            do
            {
                System.Console.Write("Digite o email: ");
                email = Console.ReadLine();
                
                if (!ValidacoesUtil.ValidadorDeEmail(email)){
                    System.Console.WriteLine("Email Inválido");   
                }

            } while (!ValidacoesUtil.ValidadorDeEmail(email));

            System.Console.Write("Digite sua Senha: ");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRetornado = usuarioRepositorio.BuscarUsuario(email, senha);
            if (usuarioRetornado != null)
            {
                return usuarioRetornado;
            }else{
                System.Console.WriteLine($"Usuário ou senha inválida");
                return usuarioRetornado;
            }

        }//FIM EFETUAR LOGIN

    }
}