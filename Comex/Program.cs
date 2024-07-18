//card welcome
string welcome = "Welcome to Comex";
List<string> listaProduto = new List<string>();
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
    string produto = Console.ReadLine()!;
    listaProduto.Add(produto);
    Console.WriteLine($"Produto {produto} adicionado com sucesso");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();


}

void ListaProduto()
{
    Console.Clear();
    Console.WriteLine("----Lista de Produtos----");
    if (listaProduto.Count == 0)
    {
        Console.WriteLine("Nenhum produto registrado.");
    }
    else
    {
        foreach (var produto in listaProduto)
        {
            Console.WriteLine(produto);
        }
    }
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
            //criar produto
            CriarProduto();
            break;
        case 2:
            //listar produto
            ListaProduto();
            break;
        case 0:
            //sair
            break;
        default:
            Console.WriteLine("Opção inválida"); Console.WriteLine("Opcão inválida");
            break;
    }
}

ExibirOpcoesMenu();