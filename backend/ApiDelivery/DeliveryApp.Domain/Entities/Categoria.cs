namespace DeliveryApp.Domain.Entities
{
    public class Categoria : EntidadeBase
    {
        public string Nome { get; set; } = null!; 
        public string? Descricao { get; set; }
        public string? Imagem { get; set; }

        //Propriedade de relacionamento/navegação
        public ICollection<Estabelecimento>? Estabelecimentos { get; set; }
    }
}
