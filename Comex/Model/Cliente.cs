using Comex.Model;

internal class Cliente : IIdentificar
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public Cliente(string nome)
    {
        Nome = nome;
    }
    public string Identificar()
    {
        return $"Nome: {Nome}\nISBN: {Cpf}";
    }
}