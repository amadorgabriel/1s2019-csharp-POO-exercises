using System;
using Senai.PastelStore.MVC.Repositorio;
using Senai.PastelStore.MVC.Utils;
using Senai.PastelStore.MVC.ViewController;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcaoDeslogado = 0;
            do
            {
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcaoDeslogado)
                {
                    case 1:
                        //CADASTRAR
                        UsuarioViewController.CadastrarUsuario();
                        System.Console.WriteLine(" \n Press ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        //FAZERLOGIN
                        UsuarioViewModel usuarioRetornado = UsuarioViewController.EfetuarLogin();
                        if (usuarioRetornado != null)
                        {
                            System.Console.WriteLine($"Bem Vindo {usuarioRetornado.Nome}");
                            //colar menu logado
                            
                        }
                        break;

                    case 3:
                        //LISTAR CADASTRADOS
                        UsuarioViewController.ListarUsuario();
                        System.Console.WriteLine(" \n Press ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 0:
                        //SAIR
                        break;

                    default:
                        System.Console.WriteLine("Opção Inválida");
                        break;
                }

            } while (opcaoDeslogado != 0);
        }
    }
}