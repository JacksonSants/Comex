using Comex.Model;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace Comex.Order;

internal class OrdenarProdutos
{
    public void OrdenarPorNome(List<Produto> produtos)
    {
        Console.Clear();
        Console.WriteLine("Exibindo todos os produtos ordernados por Nome.");

        var produtosOrdenados = produtos.OrderBy(p => p.Nome).ToList();
        foreach (var produto in produtosOrdenados)
        {
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Descrição: {produto.Descricao}");
            Console.WriteLine($"Preço Unitário: {produto.PrecoUnitario}");
            Console.WriteLine($"Quantidade: {produto.Quantidade}\n");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

    public void OrdenarPorPreco(List<Produto> produtos)
    {
        Console.Clear();
        Console.WriteLine("Exibindo todos os produtos ordernados por preço.");

        var produtosOrdenados = produtos.OrderBy(p => p.PrecoUnitario).ToList();
        foreach (var produto in produtosOrdenados)
        {
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Descrição: {produto.Descricao}");
            Console.WriteLine($"Preço Unitário: {produto.PrecoUnitario}");
            Console.WriteLine($"Quantidade: {produto.Quantidade}\n");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
