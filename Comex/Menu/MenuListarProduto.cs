using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Comex.Menu
{
    internal class MenuListarProduto
    {
        public void Executar(List<Produto> produtos)
        {
            Console.Clear();
            Console.WriteLine("----Lista de Produtos----\n");

            if (produtos.Count > 0)
            {
                Console.WriteLine("Escolha a opção de ordenação:");
                Console.WriteLine("1 - Ordenar por Nome\n2 - Ordenar por Preço");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                IEnumerable<Produto> produtosOrdenados;
                switch (opcao)
                {
                    case "1":
                        produtosOrdenados = OrdenarPorNome(produtos);
                        break;
                    case "2":
                        produtosOrdenados = OrdenarPorPreco(produtos);
                        break;
                    default:
                        produtosOrdenados = produtos;
                        break;
                }

                foreach (Produto produto in produtosOrdenados)
                {
                    Console.WriteLine($"Produto: {produto.Nome}");
                    Console.WriteLine($"Descrição: {produto.Descricao}");
                    Console.WriteLine($"Preço: {produto.PrecoUnitario.ToString("C", CultureInfo.CurrentCulture)}");
                    Console.WriteLine($"Quantidade: {produto.Quantidade}\n");
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto registrado.");
            }

            Console.WriteLine("\nAperte enter para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }

        private IEnumerable<Produto> OrdenarPorNome(IEnumerable<Produto> produtos)
        {
            return produtos.OrderBy(p => p.Nome).ToList();
        }

        private IEnumerable<Produto> OrdenarPorPreco(IEnumerable<Produto> produtos)
        {
            return produtos.OrderBy(p => p.PrecoUnitario).ToList();
        }
    }
}
