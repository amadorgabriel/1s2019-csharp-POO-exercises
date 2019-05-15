using System;
using System.Collections.Generic;
using System.IO;
using FinancaDeMesa.ViewModel;
using Spire.Doc;
using Spire.Doc.Documents;

namespace FinancaDeMesa.Repositorio
{
    public class TransacaoRepositorio
    {
        public static TransacoesViewModel Inserir(TransacoesViewModel transacao, UsuarioViewModel UserRec)
        {
            transacao.IdUsuarioCriador = UserRec.Id; // Id da transação é igual a do usuário logado

            StreamWriter arquivo = new StreamWriter("transacoes.csv", true);
            arquivo.WriteLine($"{transacao.TipoTransacao}; {transacao.Descricao}; {transacao.Valor}; {transacao.DataTransacao}; {transacao.IdUsuarioCriador}");
            arquivo.Close();
            return transacao;
            // using xxxxxx{   USA UMA BIBLIOTECA EM UM LOCAL ESPECÍFICO

            // }
        }

        public static List<TransacoesViewModel> TrazerListaDeTransacoes()
        {
            List<TransacoesViewModel> ListaDeTransacoes = new List<TransacoesViewModel>();
            TransacoesViewModel transacao;
            string[] transacoes = File.ReadAllLines("transacoes.csv");
            if (!File.Exists("transacoes.csv"))
            {
                return null;
            }

            foreach (var usuario in transacoes)
            {
                if (usuario != null)
                {

                    string[] dadosDaTransacao = usuario.Split(";");
                    transacao = new TransacoesViewModel();
                    transacao.TipoTransacao = dadosDaTransacao[0];
                    transacao.Descricao = dadosDaTransacao[1];
                    transacao.Valor = double.Parse(dadosDaTransacao[2]);
                    transacao.DataTransacao = DateTime.Parse(dadosDaTransacao[3]);
                    transacao.IdUsuarioCriador = int.Parse(dadosDaTransacao[4]);
                    ListaDeTransacoes.Add(transacao);
                } //fim if null
            } //fim foreach
            return ListaDeTransacoes;
        } // fim listar


        public static Document GerarDocWord(UsuarioViewModel DadosUserLogado)
        {
            Document doc = new Document();
            Paragraph Para = doc.AddSection().AddParagraph();
            var ListaUser = UsuarioRepositorio.TrazerListaDeUsuario();
            UsuarioViewModel usuario = new UsuarioViewModel();
            TransacoesViewModel transacao = new TransacoesViewModel();
  
            Para.AppendText("                                                                 Relatório das Minhas Transações                                                  ");
            // foreach (var item in ListaUser)
            // {
            //     if (item.Email.Equals(DadosUserLogado.Email) && item.Senha.Equals(DadosUserLogado.Senha) && item != null)
            //     {
                    //Escrever relatório das transações do user
                    foreach (var user in ListaUser)
                    {
                        if (user.Id.Equals(transacao.IdUsuarioCriador) && user != null)
                        {
                            Para.AppendText($"Id Usuário Criador: {transacao.IdUsuarioCriador} - Tipo da Transação: {transacao.TipoTransacao} - Descrição: {transacao.Descricao} - Valor: {transacao.Valor} - Data da Transação: {transacao.DataTransacao}");

                        }
                    }
            //     }
            // }
            doc.SaveToFile("ExtratoMinhasTransações.docx");
            return doc;
        }

    }
}