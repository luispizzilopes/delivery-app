namespace DeliveryApp.Domain.Entities; 

public class Item : EntidadeBase
{
    public int EstabelecimentoId { get; set; }
    public int CategoriaItemId { get; set; }
    public string Nome { get; set; } = null!; 
    public string Descricao { get; set; } = null!;
    public string Imagem { get; set; } = null!;
    public bool Promocao { get; set; }

    //Propriedade de relacionamento/navegação 
    public Estabelecimento Estabelecimento { get; set; } = new();
    public CategoriaItem CategoriaItem { get; set; } = new(); 

    public ICollection<Preco>? Precos { get; set; }
}
