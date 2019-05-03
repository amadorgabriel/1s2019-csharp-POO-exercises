using System;
using Senai.Revisao.MVC.Util;
using Senai.Revisao.MVC.ViewController;

namespace Senai.Revisao.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            do
            {
                Console.Clear();
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());
                switch (opcaoDeslogado)
                {
                    case 1:
                        Console.Clear();
                        UsuarioViewController.CadastrarUsuario();
                        break;

                    case 2:
                        Console.Clear();
                        //LISTAR
                        break;

                    case 3:
                        //LOGIN
                        break;

                    case 0:
                        System.Console.WriteLine("Volte Sempre");
                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida");
                        Console.ReadLine();
                        break;
                }
            } while (opcaoDeslogado != 0);


        }
    }
}
