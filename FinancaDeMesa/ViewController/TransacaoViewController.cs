using System;
using System.Threading;
using FinancaDeMesa.Repositorio;
using FinancaDeMesa.Util;
using FinancaDeMesa.ViewModel;
using Ionic.Zip;

namespace FinancaDeMesa.ViewController {
    public class TransacaoViewController {
        public static void CadastrarTransacao (UsuarioViewModel UserLogado) {
            string descricao;
            double valor, confirmaValor;
            string tipoTransacao;

            do {
                MenuUtil.EscolhaTransacao ();
                int codigo = int.Parse (Console.ReadLine ());
                switch (codigo) {
                    case 1:
                        tipoTransacao = "Despesa";
                        break;

                    case 2:
                        tipoTransacao = "Receita";
                        break;

                    default:
                        System.Console.WriteLine ("Código Inválido");
                        Thread.Sleep (2000);
                        tipoTransacao = "null";
                        break;
                }
            } while (tipoTransacao.Equals ("null")); // Fim Tipo Transação

            do {
                System.Console.Write ("Digite o Valor da Transação: ");
                valor = double.Parse (Console.ReadLine ());
                System.Console.Write ("Confirme o valor da Transação: ");
                confirmaValor = double.Parse (Console.ReadLine ());

                if (!ValidacoesUtil.ValidarValorTransacao (valor, confirmaValor)) //se for false
                {
                    System.Console.WriteLine ("Valores Incorretos, redigite-os");
                }

            } while (!ValidacoesUtil.ValidarValorTransacao (valor, confirmaValor)); // Fim do Valor Transação

            do {
                System.Console.WriteLine ("Escreva a descrição da Transação: ");
                descricao = Console.ReadLine (); // VALIDAR CASO ELE NÃO DIGITOU NADA
                if (string.IsNullOrEmpty (descricao)) {
                    System.Console.WriteLine ("Escreva Algo Válido ");
                    Thread.Sleep (2000);
                }
            } while (string.IsNullOrEmpty (descricao)); //Fim da descrição

            TransacoesViewModel transacao = new TransacoesViewModel ();
            transacao.Descricao = descricao;
            transacao.Valor = valor;
            transacao.TipoTransacao = tipoTransacao;
            transacao.DataTransacao = DateTime.Now;

            //INSERIR USUÁRIO
            TransacaoRepositorio.Inserir (transacao, UserLogado);
            //INSERIR USUÁRIO

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine ("Cadastro realizado com sucesso");
            Console.ResetColor ();
            //------
        }

        public static void ExibirTransacoesTerminal () {
            var ListaTransacoes = TransacaoRepositorio.TrazerListaDeTransacoes ();
            foreach (var transacao in ListaTransacoes) {
                if (transacao != null) {
                    System.Console.WriteLine ($"Id Usuario Criador: {transacao.IdUsuarioCriador} - Tipo de Transação: {transacao.TipoTransacao} - Valor: {transacao.Valor} - Descrição: {transacao.Descricao} - Data da Transação: {transacao.DataTransacao}");
                    Console.ReadLine ();

                } else {
                    System.Console.WriteLine ("Não há mais transações cadastradas");
                    Thread.Sleep (1000);
                }
            }
        }

        public static void ExportarZip () {
            using (ZipFile zipado = new ZipFile ()){
                zipado.AddFile ("transacoes.csv");
                zipado.AddFile ("usuarios.csv");
                zipado.Save ("BancoDeDados.zip");
            }
        }

        public static void RelatarWord (UsuarioViewModel usuarioLogado) {
            var DocumentoGerado = TransacaoRepositorio.GerarDocWord (usuarioLogado);
            if (DocumentoGerado != null) {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine ($"Documento Gerado com Sucesso!");
                Console.ResetColor ();
            } else {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("Houve algum erro, tente novamente. Se o resultado persistir, ligue para C.A Enterprises - 25450459 ");
                Console.ResetColor ();
            }
            Thread.Sleep (2000);
        }
    }
}