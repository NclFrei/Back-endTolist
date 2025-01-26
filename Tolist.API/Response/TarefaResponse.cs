namespace Tolist.API.Response;

public record TarefaResponse(int Id, string nome, string descricao, string Status, int AmbienteId, DateTime dataInicio, DateTime dataFim, string Icone);
