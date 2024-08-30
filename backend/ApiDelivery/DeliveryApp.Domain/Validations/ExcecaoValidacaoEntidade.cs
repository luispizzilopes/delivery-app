namespace DeliveryApp.Domain.Validations;

public class ExcecaoValidacaoEntidade : Exception
{
    public ExcecaoValidacaoEntidade(string erro) : base(erro)
    { }

    public static void Quando(bool valido, string erro)
    {
        if (!valido)
        {
            throw new ExcecaoValidacaoEntidade(erro); 
        }
    }
}
