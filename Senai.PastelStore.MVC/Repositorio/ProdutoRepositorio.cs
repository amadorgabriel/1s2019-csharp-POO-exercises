using System;
using System.Collections.Generic;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC.Repositorio
{
    public class ProdutoRepositorio
    {
        public static List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();

        public static ProdutoViewModel InserirProdutoLista(ProdutoViewModel produto)
        {
            produto.Id = listaDeProdutos.Count + 1;
            produto.DataCriacao = DateTime.Now;

            listaDeProdutos.Add(produto);

            return produto;
        }
        public static List<ProdutoViewModel> Listar()
        {
            return listaDeProdutos;
        }//Fim Listar

        public static ProdutoViewModel BuscarProdutoId(int idBusca)
        {
            foreach (var item in listaDeProdutos)
            {
                if (idBusca.Equals(item.Id))
                {
                    Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Preço: {item.Nome} - Categoria: {item.Categoria} - Descrição: {item.Descricao}  - Data de Criação {item.DataCriacao}");
                    return item;
                }
            }
            return null;
        }

        public static bool RemoverProduto(int idRem)
        {
            ProdutoViewModel produto;

            foreach (var item in listaDeProdutos)
            {
                if (idRem.Equals(item.Id))
                {
                    listaDeProdutos.Remove(item);
                    return true;
                }
            }
            return false;
        }

    }
}