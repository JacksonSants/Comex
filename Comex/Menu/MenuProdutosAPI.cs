using System.Globalization;
using System.Text.Json;

namespace Comex.Menu;

internal class MenuProdutosAPI
{
    public async Task Executar(List<Produto> produtos)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                Console.WriteLine("Consultar API externa de produtos");
                string response = await client.GetStringAsync("https://fakestoreapi.com/products");
                var produtosAPI = JsonSerializer.Deserialize<List<Produto>>(response);

                if (produtosAPI != null && produtosAPI.Any())
                {
                    Console.WriteLine("Escolha a opção de ordenação:");
                    Console.WriteLine("1 - Ordenar por Nome\n2 - Ordenar por Preço");
                    Console.Write("Opção: ");
                    string opcao = Console.ReadLine();

                    IEnumerable<Produto> produtosOrdenados;
                    switch (opcao)
                    {
                        case "1":
                            produtosOrdenados = OrdenarPorNome(produtosAPI);
                            break;
                        case "2":
                            produtosOrdenados = OrdenarPorPreco(produtosAPI);
                            break;
                        default:
                            produtosOrdenados = produtosAPI;
                            break;
                    }

                    foreach (Produto produto in produtosOrdenados)
                    {
                        Console.WriteLine($"Produto: {produto.Nome}");
                        Console.WriteLine($"Descrição: {produto.Descricao}");
                        Console.WriteLine($"Preço: {produto.PrecoUnitario.ToString("C", CultureInfo.CurrentCulture)}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum produto registrado.");
                }

                Console.WriteLine("\nAperte enter para voltar ao menu");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao consultar API: {ex.Message}");
            }
        }
    }

    private IEnumerable<Produto> OrdenarPorNome(IEnumerable<Produto> produtos)
    {
        return produtos.OrderBy(p => p.Nome).ToList();
    }

    private IEnumerable<Produto> OrdenarPorPreco(IEnumerable<Produto> produtos)
    {
        return produtos.OrderBy(p => p.PrecoUnitario).ToList();
    }
}
