using System;
using Senai.Revisao.MVC.Repositorio;
using Senai.Revisao.MVC.Util;
using Senai.Revisao.MVC.ViewController;
using Senai.Revisao.MVC.ViewModel;

namespace Senai.Revisao.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            do
            {
                
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());
                switch (opcaoDeslogado)
                {
                    case 1:
                        //CADASTRAR
                        Console.Clear();
                        UsuarioViewController.CadastrarUsuario();
                        Console.ReadLine();

                        break;

                    case 2:
                        //LISTARcc
                        Console.Clear();
                        UsuarioViewController.ListarUsuarios();
                        Console.ReadLine();
                        
                        break;

                    case 3:
                        //LOGIN
                        Console.Clear();

                        UsuarioViewModel userRecuperado = UsuarioViewController.EfetuarLogin();

                        if (userRecuperado == null)
                        {
                            System.Console.WriteLine("hehe");
                        }else{
                            System.Console.WriteLine($"Bem vindo, {userRecuperado.Nome}");
                            int opcaoLogado = 0;

                            do
                            {
                            //MENULOGADO
                                MenuUtil.MenuLogado();
                                opcaoLogado = int.Parse(Console.ReadLine());

                                switch (opcaoLogado)
                                {
                                    case 1:
                                        //CADASTRAR NEW PRODUTO
                                        ProdutoViewController.CadastrarProduto(userRecuperado);
                                        break;

                                    case 2:
                                        //LISTAR PRODUTOS
                                        ProdutoViewController.Listar();
                                        break;

                                    case 3:
                                        //BUSCAR POR ID
                                        break;
                                    case 0:
                                        //SAIR
                                        break;

                                    default:
                                        System.Console.WriteLine("Opção Inválida");
                                        Console.ReadLine();
                                        break;
                                }
                            } while (opcaoDeslogado != 0);
                        }

                        break;

                    case 0:
                        System.Console.WriteLine("Volte Sempre");
                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida");
                        Console.ReadLine();
                        break;
                }
            } while (opcaoDeslogado != 0);


        }
    }
}
