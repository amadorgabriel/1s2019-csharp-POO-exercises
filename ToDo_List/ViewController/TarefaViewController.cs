using System;
using System.Threading;
using ToDo_List.Repositorio;
using ToDo_List.ViewModel;

namespace ToDo_List.ViewController
{
    public class TarefaViewController
    {
        public static int contador = 0;
        public static bool repetir1 = false;
        public static void CadastrarTarefa()
        {
            string nomeTarefa;
            string descricaoTarefa;
            string tipoTarefa;

            System.Console.Write("Digite o título da nova Tarefa: ");
            nomeTarefa = Console.ReadLine();

            System.Console.Write("Digite a descrição da Tarefa: ");
            descricaoTarefa = Console.ReadLine();

            do
            {

                System.Console.WriteLine("Deseja adicionar a tarefa em: ");
                System.Console.WriteLine(" 1 - A FAZER");
                System.Console.WriteLine(" 2 - FAZENDO");
                System.Console.WriteLine(" 3 - FEITO");
                System.Console.Write("Código: ");
                int codigo = int.Parse(Console.ReadLine());
                if (1.Equals(codigo))
                {
                    System.Console.WriteLine("Registrando..");
                    Thread.Sleep(1500);
                    tipoTarefa = "A FAZER";
                    break;

                }
                else if (2.Equals(codigo))
                {
                    System.Console.WriteLine("Registrando..");
                    Thread.Sleep(1500);
                    tipoTarefa = "FAZENDO";
                    break;
                }
                else if (3.Equals(codigo))
                {
                    System.Console.WriteLine("Registrando..");
                    Thread.Sleep(1500);
                    tipoTarefa = "FEITO";
                    break;

                }
                else
                {
                    tipoTarefa = null;
                    System.Console.WriteLine("Código inválido, PRESS ENTER para digitar novamente");
                    Console.ReadLine();
                    bool repetir1 = true;
                }
            } while (repetir1 == false);


            TarefaViewModel tarefa = new TarefaViewModel();
            tarefa.Nome = nomeTarefa;
            tarefa.Descricao = descricaoTarefa;
            tarefa.Datacriacao = DateTime.Now;
            tarefa.Id = contador;
            tarefa.IdUsuario = UsuarioViewController.UserSelecionado.Id;
            tarefa.TipoTarefa = tipoTarefa;

            contador++;

            TarefaRepositorio.Inserir(tarefa);

            System.Console.WriteLine("TAREFA CADASTRADA COM SUCESSO! -- PRESS ENTER -- ");
            Console.ReadLine();


        }// FIM CADASTRAR
    }
}