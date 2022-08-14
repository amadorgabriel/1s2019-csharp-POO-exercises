using System;
using System.Collections.Generic;
using Senai.Revisao.MVC.Repositorio;
using Senai.Revisao.MVC.ViewModel;

namespace Senai.Revisao.MVC.ViewController
{
    public class ProdutoViewController
    {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        public static void CadastrarProduto(UsuarioViewModel usuario){
            string nome, descricao, categoria;
            float preco;

            System.Console.Write("Digite o nome do produto: ");
            nome = Console.ReadLine();
            
            System.Console.Write("Digite a descrição do produto: ");
            descricao = Console.ReadLine();
            
            System.Console.Write("Digite a categoria: ");
            categoria = Console.ReadLine();
            
            System.Console.Write("Digite o preço: ");
            preco = float.Parse(Console.ReadLine());

            ProdutoViewModel produto = new ProdutoViewModel();
            produto.Nome = nome;
            produto.Descricao = descricao;
            produto.Categoria = categoria;
            produto.Preco = preco;
            produto.IdResponsavel = usuario.Id;


            ProdutoRepositorio.Inserir(produto);

            Console.WriteLine("Produto cadastrado com sucesso");
        }

        public static void Listar(){
            List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.Listar();
            foreach (var item in listaDeProdutos)
            {
                if (item != null)
                {
                    System.Console.WriteLine($"ID {item.Nome} - Nome {item.Nome} - Criador {item.IdResponsavel}");
                }
            }
        }
    }
}