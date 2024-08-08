using Comex.Model;

namespace Comex.Menu;

internal class MenuItemPedido
{
    public void Executar(List<Produto> produtos, List<ItemPedido> itensPedido)
    {
        Console.Write("Digite o número do produto: ");
        int numeroProduto = int.Parse(Console.ReadLine()!);

        if (numeroProduto > 0 && numeroProduto <= produtos.Count)
        {
            var produtoEscolhido = produtos[numeroProduto - 1];

            Console.Write("Digite a quantidade que deseja: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            var precoUnitario = produtoEscolhido.PrecoUnitario;

            // Cria um item de pedido e adiciona à lista de itens
            ItemPedido item = new ItemPedido(produtoEscolhido, quantidade, precoUnitario);
            itensPedido.Add(item);

            Console.WriteLine($"Produto {produtoEscolhido.Nome} adicionado ao pedido!");
        }
        else
        {
            Console.WriteLine("Número do produto inválido. Tente novamente.");
        }
    }
}
