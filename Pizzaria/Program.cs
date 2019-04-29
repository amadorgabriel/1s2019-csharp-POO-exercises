using System;
using System.Threading;

namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {


            int numUsuario = 0;
            Usuario[] usuarios = new Usuario[numUsuario];
            bool sair = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Bem Vindo a Pizzaria Amador");
                Console.ResetColor();
                System.Console.WriteLine("   Abaixo segue o menu:    ");
                System.Console.WriteLine(" ");
                System.Console.WriteLine(" 1 - Cadastro              ");
                System.Console.WriteLine(" 2 - Efetuar Login         ");
                System.Console.WriteLine(" 3 - Listagem de Usuário   ");
                System.Console.WriteLine(" 9 - Sair                  ");
                System.Console.WriteLine("---------------------------");
                System.Console.Write("Digite a opção desejada: ");
                int codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        //Cadastrar

                        Usuario.Inserir();

                        
                        // usuarios[numUsuario] = Usuario.quantUsuarios;
                        // numUsuario ++;

                        break;

                    case 2:
                        //Login
                        break;

                    case 3:
                        //Listagem cadastrados
                        break;

                    case 9:
                        System.Console.WriteLine("Saindo..");
                        Thread.Sleep(2000);
                        sair = true;
                        break;

                    default:
                        System.Console.WriteLine("Código inválido, voltando para o menu..");
                        Thread.Sleep(2000);
                        Console.Clear();
                        sair = false;
                        break;
                }

            } while (!sair); // !sair




        }
    }
}
