using System;
using System.Threading;
using Senai.PastelStore.MVC.Repositorio;
using Senai.PastelStore.MVC.Utils;
using Senai.PastelStore.MVC.ViewController;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;
            do
            {
                //Menu Deslogado
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1:
                        //Cadastrar usuário
                        UsuarioViewController.CadastrarUsuario();
                        break;

                    case 2:
                        //Efetuar Login
                        UsuarioViewModel usuarioRetornado = UsuarioViewController.EfetuarLogin();
                        if (usuarioRetornado != null)
                        {
                            Console.WriteLine($"Bem vindo {usuarioRetornado.Nome}");
                            //Coloar O menu Logado

                            do
                            {

                                MenuUtil.MenuLogado();
                                opcaoLogado = int.Parse(Console.ReadLine());
                                switch (opcaoLogado)
                                {
                                    case 1:
                                        //CADASTAR PRODUTOS
                                        ProdutoViewController.CadastarProduto();

                                        break;

                                    case 2:
                                        //LISTAR
                                        ProdutoViewController.ListarProduto();

                                        System.Console.WriteLine(" ");
                                        System.Console.WriteLine("pressione ENTER para sair");
                                        Console.ReadLine();
                                        
                                        break;

                                    case 3:
                                        //BUSCA POR ID
                                        System.Console.Write("Digite qual ID proucura: ");
                                        int idBusca = int.Parse(Console.ReadLine());
                                        ProdutoRepositorio.BuscarProdutoId(idBusca);
                                        break;

                                    case 4:
                                        //VALOR TOTAL
                                        
                                        break;

                                    case 5:
                                        //ALTERAR
                                        
                                        break;

                                    case 6:
                                        //REMOVER
                                        System.Console.Write("Digite o Id do produto que deseja remover: ");
                                        int IdRem = int.Parse(Console.ReadLine());
                                        bool REMoiNAO = ProdutoRepositorio.RemoverProduto(IdRem);
                                        if (ProdutoRepositorio.RemoverProduto(IdRem) == false)
                                        {
                                            System.Console.WriteLine("Produto Removido");
                                        }else
                                        {
                                            System.Console.WriteLine("Produto não Existente");
                                        }

                                        break;

                                    case 0:
                                        //SAIR
                                        System.Console.WriteLine("Ok, volte sempre");
                                        Thread.Sleep(2000);
                                        break;

                                    default:
                                        Console.WriteLine("Opção Inválida");
                                        break;
                                }
                            } while (opcaoLogado != 0);
                        }//fim If
                        break;

                    case 3:
                        //Listar usuários Cadastrados
                        UsuarioViewController.ListarUsuario();
                        break;

                    case 0:
                        //Sair
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (opcaoDeslogado != 0);
        }
    }
}
