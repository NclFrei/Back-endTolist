using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolist.Modelos;

public class Ambiente
{
    public virtual ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
    public string Nome {  get; set; }
    public string Descricao { get; set; }
    public string icone { get; set; }
    public int Id {  get; set; }

    public void AdicionarTarefa(Tarefa tarefa)
    {
        Tarefas.Add(tarefa);
    }
}
