
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
                if (produtosAPI != null )
                {
                    foreach (var produto in produtosAPI)
                    {
                        Console.WriteLine($"Nome: {produto.Nome}");
                        Console.WriteLine($"Descrição: {produto.Descricao}");
                        Console.WriteLine($"Preço: {produto.PrecoUnitario}\n");
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
                Console.WriteLine($"Erro ao consultar API. {ex.Message}");
            }
        }
    }
}
