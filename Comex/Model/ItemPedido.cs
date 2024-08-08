namespace Comex.Model;

internal class ItemPedido
{
    Produto  Produto { get; }
    public int Quantidade { get; }
    public double PrecoUnitario { get; }
    public double SubTotal { get; }

    public ItemPedido(Produto produto, int quantidade, double precoUnitario)
    {
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
        SubTotal = quantidade * PrecoUnitario;
    }
}
