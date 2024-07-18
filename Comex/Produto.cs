// Produto.cs
using System;
using System.Collections.Generic;
using System.Globalization;

public class Produto
{
    public Produto(string nome, string descricao, float precoUnitario, int quantidade)
    {
        Nome = nome;
        Descricao = descricao;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }

    public string Nome { get; }
    public string Descricao { get; }
    public float PrecoUnitario { get; }
    public int Quantidade { get; }

    public static void CriarProduto(List<Produto> produtos)
    {
        Console.Clear();
        Console.WriteLine("----Registro de produto----");
        Console.Write("Digite o nome do produto: ");
        string nomeProduto = Console.ReadLine()!;

        Console.Write("Descrição do produto: ");
        string descricao = Console.ReadLine();

        Console.Write("Preço: ");
        string precoInput = Console.ReadLine();
        float precoUnitario = float.Parse(precoInput, CultureInfo.InvariantCulture);

        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto produto = new Produto(nomeProduto, descricao, precoUnitario, quantidade);
        produtos.Add(produto);

        Console.WriteLine($"\nProduto {produto.Nome} adicionado com sucesso");
        Console.WriteLine("Aperter enter para voltar ao menu principal");
        Console.ReadKey();
    }

    public static void ListaProduto(List<Produto> produtos)
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
                Console.WriteLine($"Preço Unitário: {produto.PrecoUnitario:F2}");
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
    }
}
