using System;
using System.Collections.Generic;
using System.Threading;
using Senai.PastelStore.MVC.Repositorio;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC.ViewController
{
    public class ProdutoViewController
    {
        public static int contador = 0;
        public static void CadastarProduto()
        {
            int opcaoCategoria;
            bool naoRepetir = false;
            string nome;
            float preco;
            string categoria;
            string descricao;


            System.Console.Write("Digite o nome do novo produto: ");
            nome = Console.ReadLine();

            System.Console.Write("Digite o preço do produto: ");
            preco = float.Parse(Console.ReadLine());

            do // ! SAIR DESSE LOOP !
            {
                System.Console.WriteLine("    O seu produto é: ");//CATEGORIA
                System.Console.WriteLine("    0 - ALIMENTO ");
                System.Console.WriteLine("    1 - BEBIDA     ");
                opcaoCategoria = int.Parse(Console.ReadLine());
                switch (opcaoCategoria)
                {
                    case 0:
                        System.Console.WriteLine("Certo, Alimento!");
                        categoria = "ALIMENTO";
                        naoRepetir = true;

                        break;

                    case 1:
                        System.Console.WriteLine("Certo, Bebida! ");
                        categoria = "BEBIDA";
                        naoRepetir = true;

                        break;

                    default:
                        categoria = " ";

                        System.Console.WriteLine("Não entendi, digite novamente..");
                        Thread.Sleep(1000);
                        opcaoCategoria = 7;
                        break;
                }
            } while (naoRepetir = false);

            System.Console.WriteLine("Digite a descrição do produto: ");
            descricao = Console.ReadLine();

            System.Console.WriteLine("gravando.. ");
            Thread.Sleep(1500);

            System.Console.WriteLine("Todos os dados estão corretos?");
            System.Console.WriteLine("    0 - Sim ");
            System.Console.WriteLine("    1 - Não     ");
            string dadosCorretos = Console.ReadLine();

            if (!"0".Equals(dadosCorretos))
            {
                System.Console.WriteLine("Certo, excluindo cadastro");
            }
            else
            {
                ProdutoViewModel produto = new ProdutoViewModel();
                produto.Nome = nome;
                produto.Preco = preco;
                produto.Categoria = categoria;
                produto.DataCriacao = DateTime.Now;
                produto.Descricao = descricao;
                produto.Id = contador + 1;

                ProdutoRepositorio.InserirProdutoLista(produto);

                System.Console.WriteLine("Produto Cadastrado!");
            }//FIM CADASTRO
        }

        public static void ListarProduto()
        {
            List<ProdutoViewModel> listaDeProdutos = ProdutoRepositorio.Listar();

            foreach (var item in listaDeProdutos)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Preço: {item.Nome} - Categoria: {item.Categoria} - Descrição: {item.Descricao}  - Data de Criação {item.DataCriacao}");
            }

        }//Fim Listar Usuario

        public static void ValorTotal()
        {
            int i = 0;
            int contador = 0;
            float[] precosProdutos = new float[1000];

            foreach (var item in ProdutoRepositorio.listaDeProdutos)
            {
                item.Preco = precosProdutos[i];
                i++;
            }

            float valorTotal = produto + precosProdutos[contador++];

            System.Console.WriteLine($"O valor total da soma de todos os produtos equivale a: {ProdutoRepo}");
        }
    }
}