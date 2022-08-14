using System;
using System.Collections.Generic;
using ColetaDeLixo_MVC.Utils;
using ColetaDeLixo_MVC.ViewModel;
using static ColetaDeLixo_MVC.Utils.Enum;

namespace ColetaDeLixo_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcoesLixos = new List<string>() {

                "   -    1 _ Bicicleta(vários)           ",
                "   -    2 _ Latinha                      ",
                "   -    3 _ Maçã                        ",
                "   -    4 _ Rótulo Alimentos            ",
                "   -    5 _ Prato Descartável           ",
                "   -    6 _ Garrafa de Vidro            ",
                "   -    7 _ Sair                        ",

            };
            bool querSair = false;
            int opcaoEscolhida = 0;
            do
            {
                bool lixoSelecionado = false;
                do
                {
                    Console.Clear();

                    MenuUtils.MenuDeItems();
                    for (int i = 0; i < opcoesLixos.Count; i++)
                    {
                        string traco = TratarTituloMenu(opcoesLixos[i]); //
                        if (opcaoEscolhida == i)
                        {
                            DestacarOpcao(opcoesLixos[i].Replace(i.ToString(), traco).Replace("-", ">"));
                        }
                        else
                        {
                            System.Console.WriteLine(opcoesLixos[i].Replace(i.ToString(), traco));
                        }
                    }

                    var teclaSel = Console.ReadKey(true).Key;
                    switch (teclaSel)
                    {
                        case ConsoleKey.UpArrow:
                            opcaoEscolhida = opcaoEscolhida == 0 ? opcaoEscolhida : --opcaoEscolhida; // EXTREMO CIMA
                            break;

                        case ConsoleKey.DownArrow:
                            opcaoEscolhida = opcaoEscolhida == opcoesLixos.Count - 1 ? opcaoEscolhida : ++opcaoEscolhida; //EXTREMO BAIXO
                            break;

                        case ConsoleKey.Enter:
                            lixoSelecionado = true;
                            break;

                    
                    }
                } while (!lixoSelecionado);

                //bool
                // int

                switch (opcaoEscolhida)
                {
                    case 0:
                        CorTerminal("Deposite na lixeira CINZA", CoresNoTerminalEnum.CINZA);
                        Console.ReadLine();
                        break;
                    case 1:
                        CorTerminal("Deposite na lixeira Amarelo", CoresNoTerminalEnum.AMARELO);
                        Console.ReadLine();
                        break;
                    case 2:
                        CorTerminal("Deposite na lixeira Preta", CoresNoTerminalEnum.PRETO);
                        Console.ReadLine();     
                        break;
                    case 3:
                        CorTerminal("Deposite na lixeira Azul", CoresNoTerminalEnum.AZUL);
                        Console.ReadLine();     
                        break;
                    case 4:
                        CorTerminal("Deposite na lixeira Vermelha", CoresNoTerminalEnum.VERMELHO);
                        Console.ReadLine();     
                        break;
                    case 5:
                        CorTerminal("Deposite na lixeira Verde", CoresNoTerminalEnum.VERDE);
                        Console.ReadLine();    
                        break;
                    case 6:
                        querSair = true;
                        break;
                }
            } while (!querSair);
            Console.Clear();


        }








        public static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }

        public static void DestacarOpcao(string opcao)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(opcao);
            Console.ResetColor();
        }

    }

}