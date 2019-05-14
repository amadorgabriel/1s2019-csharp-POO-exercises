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
        public static TransacoesViewModel Inserir(TransacoesViewModel transacao)
        {

            StreamWriter arquivo = new StreamWriter("transacoes.csv", true);

            arquivo.WriteLine($"{transacao.TipoTransacao}; {transacao.Descricao}; {transacao.Valor}; {transacao.DataTransacao}");
            arquivo.Close();
            return transacao;
            // using {

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
                    transacao.TipoTransacao = dadosDaTransacao[2];
                    transacao.Descricao = dadosDaTransacao[0];
                    transacao.Valor = double.Parse(dadosDaTransacao[1]);
                    transacao.DataTransacao = DateTime.Parse(dadosDaTransacao[3]);
                    ListaDeTransacoes.Add(transacao);
                } //fim if null
            } //fim foreach
            return ListaDeTransacoes;
        } // fim listar


        public static void GerarDocWord(){
            Document doc = new Document();
            Paragraph Para = doc.AddSection().AddParagraph();
            var ListaUser =  UsuarioRepositorio.TrazerListaDeUsuario();
            UsuarioViewModel usuario = new UsuarioViewModel();

            Para.AppendText("                                                  Relatório dos Usuários Cadastrados                                                  ");            
            foreach (var item in ListaUser)
            {
                Para.AppendText($"Nome: {item.Nome } - Id: {item.Id} - Email: {item.Email} - Data de Nacimento: {item.DataNacimento}");
                    // foreach (var item in collection)
                    // {
                        
                    // }
            }



            doc.SaveToFile("ExtratoTransações.docx");
        }
    }
}