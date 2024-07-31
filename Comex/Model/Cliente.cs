internal class Cliente
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public Cliente(string nome, string cpf, string email, string prodissao, string telefone, Endereco endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Email = email;
        Profissao = prodissao;
        Telefone = telefone;
        Endereco = endereco;
    }
}