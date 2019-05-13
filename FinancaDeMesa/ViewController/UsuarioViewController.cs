using System;
using System.Collections.Generic;
using System.Threading;
using FinancaDeMesa.Repositorio;
using FinancaDeMesa.Util;
using FinancaDeMesa.ViewController;
using FinancaDeMesa.ViewModel;

namespace FinancaDeMesa.ViewController
{
    public class UsuarioViewController
    {
	 UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public static void CadastrarUsuario()
        {

            string nome, email, senha, confirmacaoSenha;
            DateTime DataNascimento;
            bool repetir = false;

            System.Console.Write("Digite seu nome completo: ");
            nome = Console.ReadLine();//FIM NOME

            do
            {
                System.Console.Write("Digite seu email: ");
                email = Console.ReadLine();

                if (!ValidacoesUtil.ValidarEmail(email))
                {
                    System.Console.WriteLine("Email Inválido, digite novamente..");
                    Thread.Sleep(2000);
                    repetir = false;
                }
                else
                {
                    repetir = true;
                }
            } while (!repetir);//FIM EMAIL

            System.Console.Write("Digite a data do seu nacimento no formato: (dd/mm/aaaa) ou (dd/mm/yyyy) ");
            DataNascimento = DateTime.Parse(Console.ReadLine());//FIM DATA NASCIMENTO

            do
            {
                System.Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();

                System.Console.Write("Digite sua senha novamente: ");
                confirmacaoSenha = Console.ReadLine();

                if (!ValidacoesUtil.ValidarSenha(senha, confirmacaoSenha))
                {
                    System.Console.WriteLine("Senhas muito curtas ou não compatíveis..");
                    Thread.Sleep(2000);
                    repetir = false;
                }
                else
                {
                    repetir = true;
                }

            } while (!repetir);//FIM SENHA E CONFIRMAÇÃO

            UsuarioViewModel usuario = new UsuarioViewModel();
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataNacimento = DataNascimento;

            //INSERIR USUÁRIO A LISTA
            UsuarioRepositorio.InserirUsuario(usuario);
            //INSERIR USUARIO

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Cadastro do usuario {usuario.Nome.ToUpper()} realizado com sucesso!"); //ESCREVER O NOME DO USUARIO
            Console.ResetColor();
            Thread.Sleep(2000);
        }

        public static UsuarioViewModel Logar()
        {
            string email, senha;

            do
            {
                System.Console.Write("Digite seu email: ");
                email = Console.ReadLine();

                if (!ValidacoesUtil.ValidarEmail(email))
                {
                    System.Console.WriteLine("Email Inválido..");
                    Thread.Sleep(1200);
                }

            } while (!ValidacoesUtil.ValidarEmail(email));

            System.Console.Write("Digite sua senha: ");
            senha = Console.ReadLine();

            UsuarioViewModel UserRecuperado = UsuarioRepositorio.TrazerUserLogado(email, senha);
            if (UserRecuperado != null)
            {
                return UserRecuperado;
            }
            else
            {
                return null;
            }


        }

    }
}