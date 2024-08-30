namespace DeliveryApp.Domain.Entities; 

public class Avaliacao : EntidadeBase
{
    public int Nota { get; set; }
    public string Comentario { get; set; } = string.Empty;
    public string UsuarioId { get; set; } = null!; 
    public int EstabelecimentoId { get; set; }

    //Propriedade relacionamento/navegação
    public Estabelecimento Estabelecimento { get; set; } = new(); 


}
