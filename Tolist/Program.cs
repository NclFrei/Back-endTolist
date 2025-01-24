using Tolist.Banco;
using Tolist.Menus;
using Tolist.Modelos;

var context = new TolistContext();
var tarefaDal = new  DAL<Tarefa>(context);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarTarefa())
 
    ;
void ExibirOpcoesMenu()
{
    Console.WriteLine("Digite 1 para registrar uma tarefa ");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuExibido = opcoes[opcaoEscolhidaNumerica];
        menuExibido.Executar(tarefaDal);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesMenu();
    }
    else 
    {
        Console.WriteLine("Opção inválida!");
    }
}

ExibirOpcoesMenu();