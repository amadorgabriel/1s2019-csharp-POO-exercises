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
                                        //Cadastrar transações -- FEITO
                                        Console.Clear();
                                        TransacaoViewController.CadastrarTransacao(UserRec);
                                        break;
                                    case 2:
                                        //Exibir Transações, ou seja infos de cada  -- SUPOSTAMENTE FEITO
                                        Console.Clear();
                                        TransacaoViewController.ExibirTransacoesTerminal();
                                        break;
                                    case 3:
                                        //Relatar no word Users -- SUPOSTAMENTE FEITO
                                        Console.Clear();
                                        UsuarioViewController.RelatarWord(); 
                                        break;
                                    case 4:
                                        //Relatar no word Transaçoes do usuario -- SUPOSTAMENTE FEITO
                                        Console.Clear();
                                        TransacaoViewController.RelatarWord(UserRec);
                                        break;
                                    case 5:
                                        Console.Clear();
                                        //Exportar Banco de Dados no zip 
                                        TransacaoViewController.ExportarZip();
                                        break;

                                    case 0: //-- FEITO
                                        System.Console.WriteLine("Saindo..");
                                        Thread.Sleep(2000);
                                        querSair2 = true;
                                        break;

                                    default://ERRO, VOLTA AO MENU PRINCIPAL -- FEITO
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
