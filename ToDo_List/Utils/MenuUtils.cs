using System;

namespace ToDo_List.Utils
{
    public class MenuUtils
    {
        public static void MenuDeslogado()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("---------- TT  Trello Terminal  ------------");
            Console.WriteLine("-------------     Conta      ---------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (1) Cadastrar Usuário            ");
            Console.WriteLine("           (2) Efetuar Login                ");
            Console.WriteLine("           (3) Listar                       ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (0) Sair                         ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           Escolha uma opção                ");
        }
    }
}