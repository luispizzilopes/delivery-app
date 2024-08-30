namespace DeliveryApp.Domain.Entities;

public class EntidadeBase
{
    public int Id { get; set; }
    public DateTimeOffset DataCriacao { get; set; }
    public DateTimeOffset? DataAtualizacao { get; set; }
    public string? IpCriacao { get; set; }
    public string? IpAtualizacao { get; set; }

    public virtual void ValidarEntidade() 
    {
        throw new NotImplementedException();
    }
}
