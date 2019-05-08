using System;

namespace ColetaDeLixo_MVC.Utils
{
    public class Enum
    {
        public enum CoresNoTerminalEnum
        {
            AMARELO = 0,
            AZUL = 1,
            CINZA = 2,
            PRETO = 3,
            VERDE = 4,
            VERMELHO = 5
        };

        public static void CorTerminal(string texto, CoresNoTerminalEnum cor)
        {
            switch (cor)
            {
                case CoresNoTerminalEnum.AMARELO:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
                case CoresNoTerminalEnum.AZUL:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
                case CoresNoTerminalEnum.CINZA:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    System.Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
                case CoresNoTerminalEnum.PRETO:
                    Console.BackgroundColor = ConsoleColor.White;
                    System.Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
                case CoresNoTerminalEnum.VERDE:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
                case CoresNoTerminalEnum.VERMELHO:
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine(texto);
                    Console.ResetColor();
                    break;
            }

        }

        // CoresNoTerminal Amarelo = CoresNoTerminal.AMARELO;
    }
}