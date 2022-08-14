using System;
using System.Collections.Generic;
using System.Threading;
using ToDo_List.ViewModel;

namespace ToDo_List.Repositorio
{
    public class TarefaRepositorio
    {
        public static List<TarefaViewModel> ListaDeTarefa = new List<TarefaViewModel>();
        public static TarefaViewModel Inserir(TarefaViewModel tarefa)
        {
            ListaDeTarefa.Add(tarefa);
            return tarefa;
        }

        // public static void Remover( int tarefaRem)
        // {

        //     foreach (var item in ListaDeTarefa)
        //     {
        //         if (item != null)
        //         {
        //             if (tarefaRem.Equals(item.Id))
        //             {
        //                 ListaDeTarefa.Remove(item);
        //                 System.Console.WriteLine("Tarefa removida com sucesso! ");
        //             }
        //         }else{
        //             System.Console.WriteLine("O Id não correspponde a nenhum item");
        //             Thread.Sleep(1000);
        //             break;
        //         }
        //     }
        // }// FIM DO REMOVER

        public static List<TarefaViewModel> Listar(){
            return ListaDeTarefa;
        }
    }
}