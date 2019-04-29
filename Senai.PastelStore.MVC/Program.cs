using System;
using Senai.PastelStore.MVC.Utils;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC {
        class Program {
            static void Main (string[] args) {

                int opcaoDeslogado = 0;
                do {
                    MenuUtil.MenuDeslogado ();
                    opcaoDeslogado = int.Parse (Console.ReadLine ());
                    switch (opcaoDeslogado) {
                        case 1:
                            //CADASTRAR
                            break;

                        case 2:
                            //FAZERLOGIN
                            break;

                        case 3:
                            //LISTR CADASTRADOS
                            break;

                        case 0:
                            //SAIR
                            break;

                        default:
                            System.Console.WriteLine("Opção Inválida");
                            break;
                    }

                } while (opcaoDeslogado != 0);                }
            }
        }