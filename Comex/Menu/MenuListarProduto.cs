
namespace Comex.Menu;

internal class MenuListarProduto
{
    public void Executar(List<Produto> produtos)
    {
        Console.Clear();
        Console.WriteLine("----Lista de Produtos----\n");
        if (produtos.Count > 0)
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Produto: {produto.Nome}");
                Console.WriteLine($"Produto: {produto.Descricao}");
                Console.WriteLine($"Produto: {produto.PrecoUnitario}");
                Console.WriteLine($"Produto: {produto.Quantidade}\n");
            }
        }
        else
        {
            Console.WriteLine("Nenhum produto registrado.");
        }
        Console.WriteLine("\nAperte enter para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
