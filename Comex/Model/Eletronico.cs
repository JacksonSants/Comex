namespace Comex.Model;

internal class Eletronico : Produto
{
    public Eletronico(string nome, string descricao, float precoUnitario, int quantidade, int voltagem, float potencia) : base(nome, descricao, precoUnitario, quantidade)
    {
        Voltagem = voltagem;
        Potencia = potencia;
    }
    public int Voltagem { get; }
    public float Potencia { get; }
}
