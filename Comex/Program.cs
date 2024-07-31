//card welcome
using System.Globalization;

string welcome = "Welcome to Comex";
List<Produto> produtos = new List<Produto>();
//card meu
void ExibirLogo()
{
    Console.WriteLine(@"
        ░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
        ██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
        ██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
        ██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
        ╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
          ░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");
    Console.WriteLine(welcome);
}

void CriarProduto()
{
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
    ExibirOpcoesMenu();


}

void ListaProduto()
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
    ExibirOpcoesMenu();

}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\n1 - Criar produto\n2 - Listar produto\n0 - Sair");
    Console.Write("Opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);

    switch (opcaoEscolhida)
    {
        case 1:
            // Create product
            CriarProduto();
            break;
        case 2:
            // List products
            ListaProduto();
            break;
        case 0:
            // Exit
            Console.WriteLine("Obrigado(a) pela preferência, volte sempre.");
            return;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();