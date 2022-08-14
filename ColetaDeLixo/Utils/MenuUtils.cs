using System.Collections.Generic;
using static ColetaDeLixo_MVC.Utils.Enum;

namespace ColetaDeLixo_MVC.Utils
{
    public class MenuUtils
    {
        public static void MenuDeItems()
        {
            string barraMenu = "========================================";
            System.Console.WriteLine(barraMenu);
            CorTerminal("C.A EnterPrise - Seu Lixo, Nosso Luxo! ", CoresNoTerminalEnum.VERMELHO);
            CorTerminal("      Bem Vindo a Coleta de Lixo!      ", CoresNoTerminalEnum.VERMELHO);
            System.Console.WriteLine(barraMenu);
            System.Console.WriteLine("        O que deseja Descartar?         ");
        }





    }
}