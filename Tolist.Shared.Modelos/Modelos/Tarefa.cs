﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolist.Modelos;

public class Tarefa
{
    public Tarefa()
    {

    }
    public Tarefa(string nome, string descricao, string status, int ambienteId ,DateTime dataInicio, DateTime dataFim, string icone)
    {
        Nome = nome;
        Descricao = descricao;
        Status = status;
        AmbienteId = ambienteId;
        DataInicio = dataInicio;
        DataFim = dataFim;
        Icone = icone;

    }

    public int Id { get; set; }
    public string Nome {  get; set; }
    public string Descricao { get; set; }
    public string? Status {  get; set; }
    public int? AmbienteId { get; set; }
    public virtual Ambiente? Ambiente { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string? Icone { get; set; }

    public void ExibirTarefa()
    {
        Console.WriteLine($"Nome: {Nome}" +
            $"Descrição: {Descricao}" +
            $"Status: {Status}" +
            $"Data inicio: {DataInicio}" +
            $"Data fim: {DataFim}" +
            $"Icone: {Icone}");
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\n Descrição: {Descricao}\n Status: {Status} \n Data inicio: {DataInicio}\n Data fim: {DataFim}\n";
    }
}
