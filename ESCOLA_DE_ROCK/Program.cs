using System;
using System.Collections.Generic;
using ESCOLA_DE_ROCK.Interfaces;
using ESCOLA_DE_ROCK.Models;

namespace ESCOLA_DE_ROCK {
    enum FormacaoEnum : uint {
        TRIO,
        QUARTETO
    }

    enum InstrumentosEnum {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        PIANO,
        TAMBORES,
        VIOLAO
    }
    class Program {
        static void Main (string[] args) {
            bool querSair = false;
            string barraMenu = "===================================";
            var opcoesFormacao = new List<string> () { //Csharp lê e percebe o tipo do var ao final
                "    - 0                         ", //32
                "    - 1                     " //28
            };
            var itensMenuFormacao = Enum.GetNames (typeof (FormacaoEnum)); //AGORA TEMOS UM ARRAY COM A PROMEIRA LINHA VAENDO 0 E A SEGUNDA VALENDO 1
            int opcaoFormacaoSelecionada = 0;

            do {
                bool formacaoEscolhida = false;
                do {

                    Console.Clear ();
                    System.Console.WriteLine ("===================================");
                    System.Console.WriteLine ("  \\m/     ESCOLA DE ROCK    \\m/    ");
                    System.Console.WriteLine ("         Esolha uma formação       ");
                    System.Console.WriteLine (barraMenu);

                    for (int i = 0; i < opcoesFormacao.Count; i++) {
                        string titulo = TratarTituloMenu (opcoesFormacao[i]);
                        if (opcaoFormacaoSelecionada == i) {
                            DestacarOpcao (opcoesFormacao[i].Replace (i.ToString (), titulo).Replace ("-", ">")); //No parametro o programa vai trocar o numero de "i" pelo titulo do enum

                        } else {
                            System.Console.WriteLine (opcoesFormacao[i].Replace (i.ToString (), titulo));
                        }
                    }

                    var tecla = Console.ReadKey (true).Key;

                    switch (tecla) {
                        case ConsoleKey.UpArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;
                            break;
                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;
                    }
                } while (!formacaoEscolhida);
                bool bandaCompleta = false;
                int vagas = 0;

                switch (opcaoFormacaoSelecionada) {
                    case 0:
                        vagas = 2;
                        do {

                            ExibirMenuDeInstrumentos ();
                            System.Console.WriteLine ("Digite o código do instrumento para a categoria HARMONIA");
                            int codigo = int.Parse (Console.ReadLine ());
                            var instrumento = Candidatos.Instrumentos[codigo];
                            var interfaceEncontrada = instrumento.GetType ().GetInterface ("IHarmonia");
                            if (interfaceEncontrada != null) {
                                vagas--;
                                ColocarNaBanda ((IHarmonia) instrumento);

                            } else {
                                continue;
                            }

                            System.Console.WriteLine ("Digite o código do instrumento para a categoria PERCUSSÃO");
                            codigo = int.Parse (Console.ReadLine ());
                            instrumento = Candidatos.Instrumentos[codigo];
                            interfaceEncontrada = instrumento.GetType ().GetInterface ("IPercussao");
                            if (interfaceEncontrada != null) {
                                vagas--;
                                ColocarNaBanda ((IPercussao) instrumento);

                            } else {
                                continue;
                            }

                            // System.Console.WriteLine ("Digite o código do instrumento para a categoria MELODIA");
                            // codigo = int.Parse (Console.ReadLine ());
                            // instrumento = Candidatos.Instrumentos[codigo];
                            // interfaceEncontrada = instrumento.GetType ().GetInterface ("IMelodia");
                            // if (interfaceEncontrada != null) {
                            //     vagas--;
                            //     ColocarNaBanda ((IMelodia) instrumento);

                            // } else {
                            //     continue;
                            // }
                            
                            if (vagas == 0) {
                                bandaCompleta = true;
                            }

                        } while (!bandaCompleta);
                        System.Console.WriteLine("Sua bada está completa!");
                        Console.ReadLine();
                        

                        break;
                    case 1:
                        break;

                }

            } while (!querSair);
        }

        public static string TratarTituloMenu (string titulo) {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());
        }

        public static void ColocarNaBanda (IHarmonia instrumento) {
            instrumento.TocarAcordes ();
        }
        public static void ColocarNaBanda (IPercussao instrumento) {
            instrumento.MaterRitmo ();
        }
        public static void ColocarNaBanda (IMelodia instrumento) {
            instrumento.TocarSolo ();
        }

        public static void DestacarOpcao (string opcao) {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine (opcao);
            Console.ResetColor ();
        }

        // public static void ExibirMenuDeCategorias () {
        //     var categorias = Enum.GetNames (typeof (CategoriaEnum));
        //     int codigo = 1;
        //     string menuInstrumentoBorda = "##############################";
        //     System.Console.WriteLine (menuInstrumentoBorda);
        //     System.Console.WriteLine ("#         Categorias        #");

        //     foreach (var categoria in categorias) {

        //         System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(categoria)}");
        //     }

        //     System.Console.WriteLine (menuInstrumentoBorda);

        // }

        public static void ExibirMenuDeInstrumentos () {
            var instrumentos = Enum.GetNames (typeof (InstrumentosEnum));
            int codigo = 1;
            string menuInstrumentoBorda = "##############################";
            System.Console.WriteLine (menuInstrumentoBorda);
            System.Console.WriteLine ("#         Instrumentos        #");

            foreach (var instrumento in instrumentos) {
                System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(instrumento)}");
            }

            System.Console.WriteLine (menuInstrumentoBorda);

        }
    }
}