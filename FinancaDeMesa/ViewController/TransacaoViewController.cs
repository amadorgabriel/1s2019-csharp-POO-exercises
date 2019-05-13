using System;
using System.Threading;
using FinancaDeMesa.Util;
using FinancaDeMesa.ViewModel;

namespace FinancaDeMesa.ViewController
{
    public class TransacaoViewController
    {
        public void CadastrarTransacao()
        {
            string descricao;
            double valor, confirmaValor;
            string tipoTransacao;
            DateTime dataTransacao;

            do
            {
                MenuUtil.EscolhaTransacao();
                int codigo = int.Parse(Console.ReadLine());
                switch (codigo)
                {
                    case 1:
                        tipoTransacao = "Despesa";
                        break;

                    case 2:
                        tipoTransacao = "Receita";
                        break;

                    case 0:
                        tipoTransacao = null;
                        break;

                    default:
                        System.Console.WriteLine("Código Inválido..");
                        tipoTransacao = null;
                        Thread.Sleep(2000);
                        break;
                }
            } while (tipoTransacao.Equals(null)); // Fim Tipo Transação

            do
            {
                System.Console.Write("Digite o Valor da Transação: ");
                valor = double.Parse(Console.ReadLine());
                System.Console.Write("Confirme o valor da Transação: ");
                confirmaValor = double.Parse(Console.ReadLine());

                if (!ValidacoesUtil.ValidarValorTransacao(valor, confirmaValor))//se for false
                {
                    System.Console.WriteLine("Valores Incorretos, redigite-os");
                }

            } while (!ValidacoesUtil.ValidarValorTransacao(valor, confirmaValor));// Fim do Valor Transação


            do
            {
                System.Console.WriteLine("Escreva a descrição da Transação: ");
                descricao = Console.ReadLine(); // VALIDAR SE ELE NÃO DOGITOU NADA
                if (string.IsNullOrEmpty(descricao))
                {
                    System.Console.WriteLine("Escreva Algo Válido ");
                    Thread.Sleep(2000);
                }
            } while (string.IsNullOrEmpty(descricao)); //Fim da descrição

            //


        }
    }
}