namespace Comex.Model;
internal class Livro : Produto, IIdentificar
{
    public Livro(string nome, string descricao, float precoUnitario, int quantidade, string isbn, int totalDePaginas) : base(nome, descricao, precoUnitario, quantidade)
    {
        Isbn = isbn;
        TotalDePaginas = totalDePaginas;

    }

    public string Identificar()
    {
        return $"Nome: {Nome}\nISBN: {Isbn}";
    }

    public string Isbn { get; }
    public int TotalDePaginas { get; }
}
