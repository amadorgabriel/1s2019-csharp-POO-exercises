using System;
namespace Senai.PastelStore.MVC.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado()
        {
            /// <summary>
            /// Mostra as opções do usuário deslogado
            /// </summary>

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------------Pizzaria C.A ------------------");
            Console.WriteLine("-------------      Conta      --------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (1) Cadastrar Usuário            ");
            Console.WriteLine("           (2) Efetuar Login                ");
            Console.WriteLine("           (3) Listar                       ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (0) Sair                         ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           Escolha uma opção                ");

        }

        /// <summary>
        /// Mostra as opções do usuário logado
        /// </summary>
        public static void MenuLogado()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-----------Pastelaria PastelStore-----------");
            Console.WriteLine("-----------      Cardápio      -------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (1) Cadastrar Produto            ");
            Console.WriteLine("           (2) Listar todos os Produtos     ");
            Console.WriteLine("           (3) Valor Total                  ");
            Console.WriteLine("           (4) Alterar                      ");
            Console.WriteLine("           (4) Remover                      ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (0) Sair                         ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           Escolha uma opção                ");
        }
    }
}