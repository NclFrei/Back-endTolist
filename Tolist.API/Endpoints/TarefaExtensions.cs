using Tolist.Modelos;
using Microsoft.AspNetCore.Mvc;
using Tolist.Banco;
using Tolist.API.Response;
using System.Runtime.InteropServices.Marshalling;

namespace Tolist.API.Endpoints;

public static class TarefaExtensions
{
    public static void AddEndPointsTarefas(this WebApplication app)
    {
        app.MapGet("/Tarefas", ([FromServices] DAL<Tarefa> dal) =>
        {
            var listaDeTarefas = dal.listar();
            if (listaDeTarefas is null)
            {
                return Results.NotFound();
            }
            var listaDeTarefasResponse = EntityListToResponseList(listaDeTarefas);
            return Results.Ok(listaDeTarefasResponse);
        });
    }

    private static ICollection<TarefaResponse> EntityListToResponseList(IEnumerable<Tarefa> tarefaList)
    {
        return tarefaList.Select(a => EntityToResponse(a)).ToList();
    }

    private static TarefaResponse EntityToResponse(Tarefa tarefa)
    {
        return new TarefaResponse(tarefa.Id, tarefa.Nome, tarefa.Descricao, tarefa.Status, tarefa.Ambiente!.Id, tarefa.DataInicio, tarefa.DataFim, tarefa.Icone);
    }


}
