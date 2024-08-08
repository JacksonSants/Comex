namespace Comex.Model;

internal class Pedido
{
    public Pedido(Cliente cliente, DateTime data, List<ItemPedido> itens)
    {
        Cliente = cliente;
        Data = data;
        Itens = itens ?? new List<ItemPedido>();
        Total = CalcularTotal();
    }

    private double CalcularTotal()
    {
        return Itens.Sum(item => (double)item.SubTotal);
    }

    public Cliente Cliente { get; set; }
    public DateTime Data { get; set; } = DateTime.Now;
    public List<ItemPedido> Itens { get; set; }
    public double Total { get; set; }
}
