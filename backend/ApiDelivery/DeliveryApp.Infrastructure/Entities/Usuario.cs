using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Infrastructure.Entities;

public class Usuario 
{
    public ICollection<Avaliacao>? Avaliacoes { get; set; }
}
