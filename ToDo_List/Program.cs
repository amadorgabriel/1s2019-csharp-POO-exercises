using System;
using System.Threading;
using ToDo_List.Utils;
using ToDo_List.ViewController;


namespace ToDo_List
{
    class Program
    {
        static void Main(string[] args)
        {

            bool sair = false;
            do
            {
                Console.Clear();
                MenuUtils.MenuDeslogado();
                int codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        //CADASTRO
                        UsuarioViewController.CadastrarUsuario();
                        break;

                    case 2:
                        //EFETUAR LOGIN
                        break;

                    case 0:
                        //SAIR
                        sair = true;
                        break;

                    default:
                        System.Console.WriteLine("Código inválido, tente novamente");
                        Thread.Sleep(2000);
                        sair = false;
                        break;
                }


            } while (!sair);
        }
    }
}
