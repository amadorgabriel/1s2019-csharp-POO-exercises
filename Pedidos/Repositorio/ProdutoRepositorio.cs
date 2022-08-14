using System;
using System.Collections.Generic;
using System.IO;
using Senai.Revisao.MVC.ViewModel;

namespace Senai.Revisao.MVC.Repositorio
{
    public class ProdutoRepositorio
    {

        public ProdutoViewModel Inserir(ProdutoViewModel produto)
        {
            List<ProdutoViewModel> listaDeProdutos = Listar();
            int contador = 0;
            if (listaDeProdutos != null)
            {
                contador = listaDeProdutos.Count;
            }
            produto.DataCriacao = DateTime.Now;
            produto.Id = contador = 1;

            StreamWriter sw = new StreamWriter("produtos.csv", true);
            sw.WriteLine($"{produto.Id};{produto.Nome};{produto.Categoria};{produto.DataCriacao};{produto.IdResponsavel};{produto.Preco}");

            sw.Close();
            return produto;
        }

        public List<ProdutoViewModel> Listar()
        {
            List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();
            ProdutoViewModel produto;

            if (!File.Exists("produtos.csv"))
            {
                return null;
            }
            string[] produtos = File.ReadAllLines("produtos.csv");

            foreach (var item in produtos)
            {
                string[] dadosDoProduto = item.Split(";");
                produto = new ProdutoViewModel();
                produto.Id = int.Parse(dadosDoProduto[0]);
                produto.Nome = dadosDoProduto[1];
                produto.Descricao = dadosDoProduto[2];
                produto.Categoria = dadosDoProduto[3];
                produto.DataCriacao = DateTime.Parse(dadosDoProduto[4]);
                produto.Preco = float.Parse(dadosDoProduto[5]);
                produto.IdResponsavel = int.Parse(dadosDoProduto[6]);
                listaDeProdutos.Add(produto);
            }
            return listaDeProdutos;
        }
    }
}