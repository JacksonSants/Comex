//card welcome
using Comex.Menu;
using System.Globalization;

List<Produto> produtos = new List<Produto>();
//card meu
async Task ExibirOpcoesMenu()
{
    Console.WriteLine("\n1 - Criar produto\n2 - Listar produto\n3 - Consultar API de produtos\n0 - Sair");
    Console.Write("Opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);

    switch (opcaoEscolhida)
    {
        case 1:
            // Criar produto
            MenuCriarProduto menu1 = new MenuCriarProduto();
            menu1.Executar(produtos);
            break;
        case 2:
            // Listar produtos
            MenuListarProduto menu2 = new MenuListarProduto();
            menu2.Executar(produtos);
            break;
        case 3:
            // Consultar API de produtos
            MenuProdutosAPI menu3 = new MenuProdutosAPI();
            await menu3.Executar(produtos);
            break;
        case 0:
            // Sair
            Console.WriteLine("Obrigado(a) pela preferência, volte sempre.");
            return;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.Clear();
    await ExibirOpcoesMenu();
}

// Iniciar o menu principal
await ExibirOpcoesMenu();