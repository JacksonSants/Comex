//card welcome
using Comex.Menu;
using Comex.Model;
using Comex.Order;
//Lista de produtos
List<Produto> produtos = new List<Produto> {
    new Produto("Nootbook Acer", "Nootbook Acer Expire E5000", 1570.00f, 20),
    new Produto("Nootbook DEL", "Nootbook DEL Expire Ae500", 1760.00f, 15),
    new Produto("Iphone", "Nootbook DEL Expire Ae500", 1760.00f, 15)
};
//Intância endereço
Endereco endereco = new Endereco();
endereco.Bairro = "São Jorge";
endereco.Numero = 1200;
endereco.Rua = "Bairro DEV";
endereco.Complemento = "Apt-12";
endereco.Cidade = "Nova York";
//Instância cliente
Cliente cliente = new Cliente("Diego");
//Lista de Itens de pedido
List<Pedido> pedidos = new List<Pedido>();

async Task ExibirOpcoesMenu()
{
    Menu.ExibirLogo();
    Console.WriteLine("\n1 - Criar produto\n2 - Listar produto\n3 - Consultar API de produtos\n4 - Criar pedido\n5 - Listar pedidos\n0 - Sair");
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
            // Consult API de products
            MenuProdutosAPI menu3 = new MenuProdutosAPI();
            await menu3.Executar(produtos);
            await ExibirOpcoesMenu();
            break;
        case 4:
            //Create demand
            MenuCriarPedido menu4 = new MenuCriarPedido();
            menu4.Executar(produtos, pedidos);
            await ExibirOpcoesMenu();
            break;
        case 5:
            //Create demand
            MenuListarPedido menu5 = new MenuListarPedido();
            menu5.Executar(pedidos);
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