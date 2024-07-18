using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //Welcome
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


        //Criar/Registrar produto
        void CriarProduto()
        {
            Console.Clear();
            Console.WriteLine("----Registro de produto----");
            Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine()!;

            Console.Write("Descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.Write("Preço: ");
            float precoUnitario = float.Parse(Console.ReadLine());

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

        //Listar produtos
        void ListaProduto()
        {
            Console.Clear();
            Console.WriteLine("----Lista de Produtos----\n");
            if (produtos.Count > 0)
            {
                int count = 1;
                foreach (Produto produto in produtos)
                {
                    Console.WriteLine($"Produto_{count}: {produto.Nome}");
                    Console.WriteLine($"Descrição: {produto.Descricao}");
                    Console.WriteLine($"Preço Unitário: {produto.PrecoUnitario}");
                    Console.WriteLine($"Quantidade: {produto.Quantidade}\n");
                    count += 1;
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

        //Menu
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
                    Console.WriteLine("Obrigado(a) pela preferência, volte sempre.");
                    break;
                default:
                    Console.WriteLine("Opção inválida"); Console.WriteLine("Opcão inválida");
                    break;
            }
        }

        ExibirOpcoesMenu();
    }
}