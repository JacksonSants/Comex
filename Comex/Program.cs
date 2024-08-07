//card welcome
using Comex.Menu;
using Comex.Model;
using Comex.Order;

List<Produto> produtos = new List<Produto> {
    new Produto("Nootbook Acer", "Nootbook Acer Expire E5000", 1570.00f, 20),
    new Produto("Nootbook DEL", "Nootbook DEL Expire Ae500", 1760.00f, 15),
    new Produto("Iphone", "Nootbook DEL Expire Ae500", 1760.00f, 15)
};

async Task ExibirOpcoesMenu()
{
    Menu.ExibirLogo();
    Console.WriteLine("\n1 - Criar produto\n2 - Listar produto\n3 - Consultar API de produtos\n0 - Sair");
    Console.Write("Opção: ");
    string opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);

    switch (opcaoEscolhida)
    {
        case 1:
            // Create product
            var menu1 = new MenuCriarProduto();
            menu1.Executar(produtos);
            await ExibirOpcoesMenu();
            break;
        case 2:
            // List products
            MenuListarProduto menu2 = new MenuListarProduto();
            menu2.Executar(produtos);
            await ExibirOpcoesMenu();
            break;
        case 3:
            // Consultar API de produtos
            MenuProdutosAPI menu3 = new MenuProdutosAPI();
            await menu3.Executar(produtos);
            await ExibirOpcoesMenu();
            break;
        case 0:
            // Exit
            Console.WriteLine("Obrigado(a) pela preferência, volte sempre.");
            return;
        default:
            Console.WriteLine("Opção inválida");
            await ExibirOpcoesMenu();
            break;
    }
    Console.Clear();
}

await ExibirOpcoesMenu();