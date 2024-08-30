namespace DeliveryApp.Domain.Entities; 

public class Estabelecimento : EntidadeBase
{
    public string Nome { get; set; } = null!; 
    public string? Descricao { get; set; } 
    public string? ImagemLogo { get; set; }
    public string? ImagemCapa { get; set; }
    public bool AceitaRetirada { get; set; }
    public bool AceitaEntrega { get; set; }
    public string? TempoMedioEntrega { get; set; }
    public decimal ValorEntrega { get; set; }

    //Propriedades de relacionamento/navegação
    public ICollection<HorarioFuncionamento>? HorariosFuncionamento { get; set; }
    public ICollection<FormaPagamento>? FormasPagamento { get; set; }
    public ICollection<Avaliacao>? Avaliacoes { get; set; }
    public ICollection<Categoria>? Categorias { get; set; }
    public ICollection<CategoriaItem>? CategoriasItem { get; set; }
}
