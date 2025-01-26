using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tolist.Banco;
using Tolist.Modelos;

namespace Tolist.Menus;

internal class MenuRegistrarTarefa : Menu 
{
    public override void Executar(DAL<Tarefa> tarefaDAL)
    {
        base.Executar(tarefaDAL);
        Console.Write("Digite o nome da sua tarefa: ");
        string nomeTarefa = Console.ReadLine()!;
        Console.Write("Digite a descrição da sua tarefa: ");
        string descricaoTarefa = Console.ReadLine()!;
        Console.WriteLine($"A tarefa {nomeTarefa} foi adiciona com sucesso!");
        Console.Clear();
    }
}
