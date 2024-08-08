using Comex.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Menu;

internal class MenuCriarPedido
{
    public void Executar(List<Produto> produtos, List<ItemPedido> itemPedidos, List<Pedido> pedidos)
    {
        Console.Clear();
        Console.WriteLine("----Criar Pedido----\n");

        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine($"\n{i + 1} - Produto: {produtos[i].Nome} - Preço: {produtos[i].PrecoUnitario:C}");
        }

        List<ItemPedido> itensPedido = new List<ItemPedido>();

        int opcao;
        do
        {
            Console.Write("Digite o número do produto para adicionar ao pedido (0 para finalizar): ");
            opcao = int.Parse(Console.ReadLine()!);

            if (opcao != 0 && opcao > 0 && opcao <= produtos.Count)
            {
                var produtoEscolhido = produtos[opcao - 1];

                Console.Write("Digite a quantidade que deseja: ");
                int quantidade = int.Parse(Console.ReadLine()!);

                var precoUnitario = produtoEscolhido.PrecoUnitario;

                ItemPedido item = new ItemPedido(produtoEscolhido, quantidade, precoUnitario);
                itensPedido.Add(item);

                Console.WriteLine($"Produto {produtoEscolhido.Nome} adicionado ao pedido!\n");
            }
            else if (opcao != 0)
            {
                Console.WriteLine("Número do produto inválido. Tente novamente.");
            }

        } while (opcao != 0);
        Console.Write("Nome do Cliente: ");
        string nomeCliente = Console.ReadLine()!;
        Cliente cliente = new Cliente(nomeCliente);

        Pedido pedido = new Pedido(cliente, DateTime.Now, itensPedido);

        pedidos.Add(pedido);

        Console.WriteLine("Pedido criado com sucesso!");
        Console.WriteLine("Aperte enter para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
