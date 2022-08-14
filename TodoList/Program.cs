using System;
using System.Threading;
using ToDo_List.Repositorio;
using ToDo_List.Utils;
using ToDo_List.ViewController;


namespace ToDo_List
{
    class Program
    {
        static void Main(string[] args)
        {

            bool sair = false;
            do
            {
                Console.Clear();
                MenuUtils.MenuDeslogado();
                int codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        //CADASTRO
                        UsuarioViewController.CadastrarUsuario();
                        break;

                    case 2:
                        //EFETUAR LOGIN
                        if (true.Equals(UsuarioViewController.EfetuarLogin()))
                        {
                            do
                            {
                                Console.Clear();
                                Utils.MenuUtils.MenuLogado();
                                codigo = int.Parse(Console.ReadLine());
                                switch (codigo)
                                {
                                    case 1:
                                        //CADASTRAR TAREFAS
                                        TarefaViewController.CadastrarTarefa();
                                        break;

                                    case 2:
                                        //EXCLUIR TAREFAS
                                        // System.Console.Write("Qual o ID da tarefa que deseja excluir: ");
                                        // int tarefaRem = int.Parse(Console.ReadLine());
                                        // TarefaRepositorio.Remover(tarefaRem);
                                        break;

                                    case 3:
                                        //LISTAR TAREFAS
                                        TarefaViewController.ListarTarefas();
                                        break;

                                    case 4:
                                        // MOVER TAREFA
                                        break;

                                    case 0:
                                        //SAIR
                                        System.Console.WriteLine("SAINDO...");
                                        Thread.Sleep(2000);

                                        break;

                                    default:
                                        System.Console.WriteLine("Código inválido, tente novamente");
                                        Thread.Sleep(2000);
                                        sair = false;

                                        break;
                                }

                            } while (codigo != 0);
                        }
                        else
                        {
                            System.Console.WriteLine("Conta não Logada..");
                        }
                        break;

                    case 3:
                        //LISTAR USERS
                        UsuarioViewController.ListarUser();

                        System.Console.WriteLine("PRESS ENTER para sair");
                        Console.ReadLine();
                        break;

                    case 0:
                        //SAIR
                        sair = true;
                        break;

                    default:
                        System.Console.WriteLine("Código inválido, tente novamente");
                        Thread.Sleep(2000);
                        sair = false;
                        break;
                }


            } while (!sair);
        }
    }
}
