using Comex.Model;
namespace Comex.Menu;

internal class MenuCriarPedido
{
    public void Executar(List<Produto> produtos, List<Pedido> pedidos)
    {
        List<ItemPedido> itensPedido = new List<ItemPedido>();
        Console.Clear();
        Console.WriteLine("----Criar Pedido----\n");

        // Exibir a lista de produtos
        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine($"\n{i + 1} - Produto: {produtos[i].Nome} - Preço: {produtos[i].PrecoUnitario:C}");
        }

        int opcao;
        do
        {
            Console.WriteLine("\n1 - Inserir produto\n0 - Finalizar");
            Console.Write("Digite a opção: ");
            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    MenuItemPedido menuItem = new MenuItemPedido();
                    menuItem.Executar(produtos, itensPedido);
                    break;
                case 0:
                    Console.Write("Nome do Cliente: ");
                    string nomeCliente = Console.ReadLine()!;
                    Cliente cliente = new Cliente(nomeCliente);

                    Pedido pedido = new Pedido(cliente, DateTime.Now, itensPedido);
                    pedidos.Add(pedido);

                    Console.WriteLine("Pedido criado com sucesso!");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != 0);

        Console.WriteLine("Aperte enter para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
