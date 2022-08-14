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
            Console.WriteLine("           (3) Listar Usuários              ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (0) Sair                         ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           Escolha uma opção                ");
        }

        public static void MenuLogado()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"---------- Bem Vindo de Volta  ------------");
            Console.WriteLine("-------------     Conta      ---------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (1) Cadastrar Tarefas            ");
            Console.WriteLine("           (2) Excluir Tarefas              ");
            Console.WriteLine("           (3) Listar Tarefas               ");
            Console.WriteLine("           (4) Mover Tarefas                ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (0) Sair da Conta                ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           Escolha uma opção                ");
        }
    }
}