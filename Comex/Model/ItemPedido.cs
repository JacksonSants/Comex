namespace Comex.Model;

internal class ItemPedido
{
    Produto  Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public decimal SubTotal { get; set; }

    public ItemPedido(Produto produto, int quantidade, decimal precoUnitario, decimal subtotal)
    {
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
        SubTotal = subtotal;
    }
}
