// Program.cs
using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        // Welcome
        string welcome = "Welcome to Comex";
        List<Produto> produtos = new List<Produto>();

        // Display Logo
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

        // Display Menu Options
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
