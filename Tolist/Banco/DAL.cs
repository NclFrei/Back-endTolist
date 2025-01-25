﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolist.Banco;

internal class DAL<T> where T : class
{
    private readonly TolistContext context;

    public DAL(TolistContext context)
    {
        this.context = context;
    }

    public IEnumerable<T> listar()
    {
        return context.Set<T>().ToList();
    }

    public void Adicionar(T objeto)
    {
        context.Set<T>().Add(objeto);
        context.SaveChanges();
    }

    public void Atualizar(T objeto)
    {
        context.Set<T>().Update(objeto);
        context.SaveChanges();
    }

    public void Deletar(T objeto)
    { 
        context.Set<T>().Remove(objeto);
        context.SaveChanges();
    }

}
