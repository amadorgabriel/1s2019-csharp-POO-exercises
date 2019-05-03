using System;
namespace Senai.Revisao.MVC.Util
{
    public class MenuUtil
    {
        public static void MenuDeslogado()
        {
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("          C.A. Enterprise         ");
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine(" 1 - INSERT NEW USER              ");
            System.Console.WriteLine(" 2 - LIST USERS                   ");
            System.Console.WriteLine(" 3 - LOGIN                        ");
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine(" 0 - EXIT                         ");
            System.Console.WriteLine("----------------------------------");
            System.Console.Write("Escreva o código: ");
        }
    }
}