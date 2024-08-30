namespace DeliveryApp.Domain.Entities; 

public class CategoriaItem : EntidadeBase
{
    public int EstabelecimentoId { get; set; }
    public string Nome { get; set; } = null!; 
    public string Descricao { get; set; } = null!;
    public string? Imagem { get; set; }

    //Propriedades de relacionamento/navegação
    public Estabelecimento Estabelecimento { get; set; } = new();
    public ICollection<Item>? Itens { get; set; }
}
