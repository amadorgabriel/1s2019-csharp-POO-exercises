using System;
using Senai.Revisao.MVC.Repositorio;
using Senai.Revisao.MVC.Util;
using Senai.Revisao.MVC.ViewModel;

namespace Senai.Revisao.MVC.ViewController
{
    public class UsuarioViewController
    {
        
        public static int contador = 0;
        public static void CadastrarUsuario()
        {
            string nome;
            string email;
            string senha;
            string confirmacao;

            do
            {
                System.Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome))
                {
                    System.Console.WriteLine("Nome Inválido");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                System.Console.Write("Digite o seu Email: ");
                email = Console.ReadLine();
                if (!ValidadorUtil.ValidarEmail(email))
                {
                    System.Console.WriteLine("Email Inválido");
                }
            } while (!ValidadorUtil.ValidarEmail(email));

            do
            {
                System.Console.Write("Digite sua Senha: ");
                senha = Console.ReadLine();
                System.Console.Write("Digite a confirmação da Senha: ");
                confirmacao = Console.ReadLine();

                if (!ValidadorUtil.ValidarSenha(senha, confirmacao))
                {
                    System.Console.WriteLine("Senha e Confirmaçõa não corespondem");
                    Console.ReadLine();
                }
            } while (!ValidadorUtil.ValidarSenha(senha, confirmacao));

            UsuarioViewModel usuario = new UsuarioViewModel();

            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataCriacao = DateTime.Now;
            usuario.Id = contador;

            contador++;

            UsuarioRepositorio.Inserir(usuario);

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Usuario Cadastrado com sucesso!");
            Console.ResetColor();


        }

        public static void ListarUsuarios(){
            ListarUsuarios<UsuarioViewModel> ListaDeUsuarios = UsuarioRepositorio.Listar();
            foreach (var item in ListaDeUsuarios)
            {
                if (item != null)
                {
                    System.Console.WriteLine($"ID: {item.Id} - Nome: {item.Nome} - Email: {item.Email} - Data de Criação: {item.DataCriacao} ");
                }                
            }
        }





    }
}