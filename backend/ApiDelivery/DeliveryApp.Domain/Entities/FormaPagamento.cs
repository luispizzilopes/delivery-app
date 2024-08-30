namespace DeliveryApp.Domain.Entities;

public class FormaPagamento : EntidadeBase
{
    public int EstabelecimentoId { get; set; }
    public string Nome { get; set; } = null!;

    //Propriedades de relacionamento/navegação
    public Estabelecimento Estabelecimento { get; set; } = new(); 
}
