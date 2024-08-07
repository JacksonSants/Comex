using Comex.Model;
using Comex.Order;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
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
                    string opcao = Console.ReadLine()!;
                    IEnumerable<Produto> produtosOrdenados;
                    switch (opcao)
                    {
                        case "1":
                            var ordenarPorNome = new OrdenarProdutos();
                            ordenarPorNome.OrdenarPorNome(produtosAPI);
                            break;
                        case "2":
                            var ordenarPorPreco = new OrdenarProdutos();
                            ordenarPorPreco.OrdenarPorPreco(produtosAPI);
                            break;
                        default:
                            produtosOrdenados = produtosAPI;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum produto registrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao consultar API: {ex.Message}");
            }
        }
    }
}
