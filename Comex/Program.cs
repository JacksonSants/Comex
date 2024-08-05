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
            // Create product
            MenuCriarProduto menu1 = new MenuCriarProduto();
            menu1.Executar(produtos);
            ExibirOpcoesMenu();
            break;
        case 2:
            // List products
            MenuListarProduto menu2 = new MenuListarProduto();
            menu2.Executar(produtos);
            break;
        case 3:
            // List products
            MenuProdutosAPI menu3 = new MenuProdutosAPI();
            await menu3.Executar(produtos);
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
    await ExibirOpcoesMenu();
}

await ExibirOpcoesMenu();