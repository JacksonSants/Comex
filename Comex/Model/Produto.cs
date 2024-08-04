// Produto.cs
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;

internal class Produto
{
    public Produto(string nome, string descricao, float precoUnitario, int quantidade)
    {
        Nome = nome;
        Descricao = descricao;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }
    [JsonPropertyName("title")]
    public string Nome { get; }
    [JsonPropertyName("description")]
    public string Descricao { get; }
    [JsonPropertyName("price")]
    public float PrecoUnitario { get; }
    public int Quantidade { get; }

}
