namespace DeliveryApp.Domain.Entities;

public class Preco : EntidadeBase
{
    public int ItemId { get; set; }
    public string Nome { get; set; } = null!; 
    public decimal? Valor { get; set; }

    public Item Item { get; set; } = new(); 
}
