using System;
using FinancaDeMesa.Util;
using System.Threading;
using FinancaDeMesa.ViewController;

namespace FinancaDeMesa
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            do
            {
                Console.Clear();
                MenuUtil.MenuDeslogado();
                int resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        UsuarioViewController.CadastrarUsuario();
                        break;

                    case 2:
                        break;

                    case 0:
                        System.Console.WriteLine("Saindo..");
                        Thread.Sleep(2000);
                        querSair = true;
                        break;

                    default:
                        System.Console.WriteLine("Código inválido.. ");
                        Thread.Sleep(2000);
                        querSair = false;
                        break;
                }

            } while (!querSair);
        }
    }
}
