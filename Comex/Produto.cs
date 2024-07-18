class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public string Descricao { get; set; }
    public float PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public void ExibirProduto()
    {
        Console.WriteLine($"\nPruduto: {Nome}");
    }
}