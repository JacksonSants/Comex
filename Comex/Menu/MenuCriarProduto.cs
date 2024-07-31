using System.Globalization;

namespace Comex.Menu;

internal class MenuCriarProduto
{
    public void Executar(List<Produto> produtos)
    {
        Menu.ExibirLogo();
        Console.Clear();
        Console.WriteLine("----Registro de produto----");
        Console.Write("Digite o nome do produto: ");
        string nomeProduto = Console.ReadLine()!;

        Console.Write("Descrição do produto: ");
        string descricao = Console.ReadLine();

        Console.Write("Preço: ");
        string precoInput = Console.ReadLine();
        float precoUnitario = float.Parse(precoInput, CultureInfo.InvariantCulture);

        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto produto = new Produto(nomeProduto, descricao, precoUnitario, quantidade);
        produtos.Add(produto);

        Console.WriteLine($"\nProduto {produto.Nome} adicionado com sucesso");
        Console.WriteLine("Aperter enter para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
