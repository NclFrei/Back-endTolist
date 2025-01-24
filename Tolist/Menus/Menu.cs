using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tolist.Banco;
using Tolist.Modelos;

namespace Tolist.Menus;

internal class Menu
{
    

    public virtual void Executar(DAL<Tarefa> tarefaDal)
    {
        Console.Clear();
    }

}
