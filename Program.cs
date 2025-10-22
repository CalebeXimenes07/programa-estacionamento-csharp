using DesafioEstacionamento.Models;

Estacionamento es = new Estacionamento();

es.SolicitandoPreco();

while (true)
{ 
    string OpcaoMenu = es.MenuEstacionamento();

switch (OpcaoMenu)
{
        case "1":
        Console.Clear();
        Console.WriteLine("Você escolheu cadastrar um veículo.");
        es.CadastrarVeiculos();
        break;

        case "2":
        Console.Clear();
        Console.WriteLine("Você escolheu remover um veículo.");
        es.RemoverVeiculos();
        break;

        case "3":
        Console.Clear();
        Console.WriteLine("Você escolheu listar os veículos.");
        es.ListarVeiculos();
        break;

        case "0":
        Console.Clear();
        Console.WriteLine("Você escolheu encerrar o programa.");
        Console.WriteLine("Programa encerrado!");
        break;

        default:
            Console.Clear();
        Console.WriteLine("Opção inválida, escolha uma opção válida.");
        break;

}

    if (OpcaoMenu == "0")
    {
        break;
    }
}