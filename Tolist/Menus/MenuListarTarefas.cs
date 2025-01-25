using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tolist.Banco;
using Tolist.Modelos;

namespace Tolist.Menus;

internal class MenuListarTarefas : Menu
{
    public override void Executar(DAL<Tarefa> tarefaDAL)
    {
        base.Executar(tarefaDAL);
        Console.Write("Tarefas Pendentes\n");
        foreach(var tarefa in tarefaDAL.listar())
        {
            Console.WriteLine($"{tarefa}");
        }

        Console.Write("\n////////////////////////////////////////////////////////////////////////////////////////\n");
    }
}
