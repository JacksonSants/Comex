internal class Program
{
    private static void Main(string[] args)
    {
        //card welcome
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
            string newProduto = Console.ReadLine()!;
            Produto produto = new Produto(newProduto);
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
                    Produto.CriarProduto(produtos);
                    break;
                case 2:
                    // List products
                    Produto.ListaProduto(produtos);
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
    }
}
