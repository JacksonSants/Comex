//card welcome
using Comex.Menu;
using System.Globalization;

List<Produto> produtos = new List<Produto>();
//card meu
void ExibirOpcoesMenu()
{
    Console.WriteLine("\n1 - Criar produto\n2 - Listar produto\n0 - Sair");
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