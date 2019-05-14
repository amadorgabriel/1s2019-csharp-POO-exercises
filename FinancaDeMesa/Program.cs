using System;
using FinancaDeMesa.Util;
using System.Threading;
using FinancaDeMesa.ViewController;
using FinancaDeMesa.ViewModel;
using FinancaDeMesa.Repositorio;

namespace FinancaDeMesa
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            int resposta;
            do
            {
                Console.Clear();
                MenuUtil.MenuDeslogado();
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        UsuarioViewController.CadastrarUsuario();
                        break;

                    case 2:
                        UsuarioViewModel UserRec = UsuarioViewController.Logar();
                        if (UserRec != null)
                        {
                            bool querSair2 = false;

                            do
                            {
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Green;
                                System.Console.WriteLine($"             Bem Vindo {UserRec.Nome}!            ");
                                Console.ResetColor();
                                MenuUtil.MenuLogado();
                                resposta = int.Parse(Console.ReadLine());
                                switch (resposta)
                                {
                                    case 1:
                                        //Cadastrar transações
                                        Console.Clear();
                                        TransacaoViewController.CadastrarTransacao();
                                        break;
                                    case 2:
                                        //Exibir Transações, ou seja infos de cada Transação
                                        break;
                                    case 3:
                                        //Relatar no word
                                        Console.Clear();
                                        TransacaoRepositorio.GerarDocWord();
                                        
                                        break;
                                    case 4:
                                        //Exportar Banco de Dados
                                        break;

                                    case 0:
                                        System.Console.WriteLine("Saindo..");
                                        Thread.Sleep(2000);
                                        querSair2 = true;
                                        break;

                                    default://ERRO, VOLTA AO MENU PRINCIPAL
                                        System.Console.WriteLine("Código inválido.. ");
                                        Thread.Sleep(2000);
                                        break;
                                }
                            } while (!querSair2);

                        }
                        else
                        {
                            System.Console.WriteLine("Usuário não Encontrado..");
                            Thread.Sleep(2000);
                            continue;
                        }

                        break;

                    case 0:
                        System.Console.WriteLine("Saindo..");
                        Thread.Sleep(2000);
                        querSair = true;
                        break;

                    default:
                        System.Console.WriteLine("Código inválido.. ");
                        Thread.Sleep(2000);
                        querSair = false;
                        break;
                }

            } while (!querSair);
        }
    }
}
