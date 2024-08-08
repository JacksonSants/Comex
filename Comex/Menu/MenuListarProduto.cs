using Comex.Model;
using Comex.Order;
using System;
using System.Globalization;

namespace Comex.Menu;

internal class MenuListarProduto
{
    public void Executar(List<Produto> produtos)
    {
        Console.Clear();
        Console.WriteLine("----Lista de Produtos----\n");

        if (produtos.Count > 0)
        {
            Console.WriteLine("Escolha a opção de ordenação:");
            Console.WriteLine("1 - Ordenar por Nome\n2 - Ordenar por Preço");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    var menu1 = new OrdenarProdutos();
                    menu1.OrdenarPorNome(produtos);
                    break;
                case 2:
                    var menu2 = new OrdenarProdutos();
                    menu2.OrdenarPorPreco(produtos);
                break;
                default:
                    Console.WriteLine("Opção inválida. Exibindo produtos sem ordenação.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Nenhum produto registrado.");
        }
    }
}
