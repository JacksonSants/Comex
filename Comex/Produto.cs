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
}
