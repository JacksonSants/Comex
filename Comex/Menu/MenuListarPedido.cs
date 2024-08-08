using Comex.Model;
using Comex.Order;

namespace Comex.Menu;

internal class MenuListarPedido
{
    public void Executar(List<Pedido> pedidos)
    {
        Console.Clear();
        Console.WriteLine("----Lista de Pedidos----\n");

        if (pedidos.Count > 0)
        {
            // Ordenaçãodes pedidos pelo nome do cliente
            var pedidosOrdenados = pedidos.OrderBy(p => p.Cliente.Nome).ToList();
            // Exibe os itens do pedido
            foreach (var pedido in pedidosOrdenados)
            {
                Console.WriteLine($"Nome do Cliente: {pedido.Cliente.Nome}");
                Console.WriteLine("Itens:");

                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine($"  - Produto: {item.Produto.Nome}, Quantidade: {item.Quantidade}, Subtotal: {item.SubTotal:C}");
                }

                Console.WriteLine($"Valor Total: {pedido.Total:C}");
                Console.WriteLine($"Data de Criação: {pedido.Data}\n");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Nenhum pedido registrado.");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
