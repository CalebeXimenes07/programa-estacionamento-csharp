using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Models;

public class Estacionamento
{
    string Opcao;
    double HorasVeiculoEstacionado;

    double PrecoInicial;
    double ValorHora;
    List<string> VeiculosEstacionamento = new List<string>();

    public void SolicitandoPreco()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Insira o preço fixo do estacionamento: ");
            string EntradaPrecoInicial = Console.ReadLine();

            if (double.TryParse(EntradaPrecoInicial, out PrecoInicial))
            {
                break;
            }

            else
            {
                Console.WriteLine("Valor inválido, insira novamente!");
            }
        } 

        while (true)
            {
            Console.WriteLine("Insira o preço por hora do estacionamento: ");
            string EntradaValorHora = Console.ReadLine();

            if (double.TryParse(EntradaValorHora, out ValorHora))
            {
                break;
            }

            else
            {
                Console.WriteLine("Valor inválido, insira novamente!");
            }
            }
        }      
    

    public void CadastrarVeiculos()
    {

        while (true)
        {
            Console.WriteLine("Digite a placa do veículo que você deseja cadastrar\nOu digite 0 para retornar ao menu principal: ");
            string PlacaVeiculo = Console.ReadLine();
            
            if (PlacaVeiculo == "0")
            {
                Console.Clear();
                break;
            }

            if (!string.IsNullOrEmpty(PlacaVeiculo))
            {
                VeiculosEstacionamento.Add(PlacaVeiculo);
                Console.Clear();
                Console.WriteLine($"\nVeículo de placa {PlacaVeiculo} foi cadastrado com sucesso!");
                break;

            }

            else
            {
                Console.WriteLine("Você não inseriu nada! ");
            }

        }
    }

    public void RemoverVeiculos()
    {
        while (true)
        {
            Console.WriteLine("Informe a placa do carro que você deseja remover do estacionamento.\nOu digite 0 para retornar ao menu principal: ");
            string PlacaVeiculoParaRemover = Console.ReadLine();
            if (PlacaVeiculoParaRemover == "0")
            {
                Console.Clear();
                break;
            }

            if (!string.IsNullOrEmpty(PlacaVeiculoParaRemover))
            {

                if (VeiculosEstacionamento.Contains(PlacaVeiculoParaRemover))
                {

                    

                    while (true)
                    {
                        Console.WriteLine("Informe a quantidade de horas que seu carro permaneceu estacionado: ");
                        string EntradasHoraVeiculoEstacionado = Console.ReadLine();

                        if (double.TryParse(EntradasHoraVeiculoEstacionado, out HorasVeiculoEstacionado))
                        {
                            double TaxaEstacionamento = PrecoInicial + (ValorHora * HorasVeiculoEstacionado);
                            Console.Clear();
                            Console.WriteLine($"O veículo de placa {PlacaVeiculoParaRemover} foi removido do estacionamento, uma taxa de R${TaxaEstacionamento} será cobrada pelo tempo estacionado!\n");
                            VeiculosEstacionamento.Remove(PlacaVeiculoParaRemover);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Valor inválido, insira um valor válido.");

                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"A placa {PlacaVeiculoParaRemover} não está cadastrada no nosso estacionada! ");
                }
            }

            else
            {
                Console.WriteLine("Você não inseriu nada! ");
            }
        }
    }

    public void ListarVeiculos()
    {
        Console.WriteLine("Veículos cadastrados: ");
        foreach (string carros in VeiculosEstacionamento)
        {
            Console.WriteLine(carros);
        }
    }

    public string MenuEstacionamento()
    {
        while (true)
        {
            
            Console.WriteLine("\nMENU ESTACIONAMENTO\n==========================\nDigite 1 para cadastrar veículo\nDigite 2 para remover veículo\nDigite 3 para listar veículos\nDigite 0 para encerrar o menu");
            Opcao = Console.ReadLine();

            return Opcao;
        }
     }

}
