using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolist.Modelos;

internal class Tarefa
{

    public Tarefa(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
    }

    public int Id { get; set; }
    public string Nome {  get; set; }
    public string Descricao { get; set; }
    public string? Status {  get; set; }
    public string? Categoria { get; set; }
    public int? AmbienteId { get; set; }
    public virtual Ambiente Ambiente { get; set; }
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
    public string? Icone { get; set; }

    public void ExibirTarefa()
    {
        Console.WriteLine($"Nome: {Nome}" +
            $"Descrição: {Descricao}" +
            $"Status: {Status}" +
            $"Categoria: {Categoria}" +
            $"Data inicio: {DataInicio}" +
            $"Data fim: {DataFim}" +
            $"Icone: {Icone}");
    }
}
