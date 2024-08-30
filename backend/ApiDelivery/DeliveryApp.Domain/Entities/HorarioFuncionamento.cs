using DeliveryApp.Domain.Enums;
using DeliveryApp.Domain.Validations;

namespace DeliveryApp.Domain.Entities; 

public class HorarioFuncionamento : EntidadeBase
{
    public int Ordem { get; set; }
    public int EstabelecimentoId { get; set; }
    public DiasSemanais Dia {  get; set; }
    public TimeSpan HorarioAbertura { get; set; }
    public TimeSpan HorarioEncerramento { get; set; }

    //Propriedade de relacionamento/navegação
    public Estabelecimento Estabelecimento { get; set; } = new();

    public HorarioFuncionamento(int ordem, int estabelecimentoId, DiasSemanais dia, TimeSpan horarioAbertura, TimeSpan horarioEncerramento)
    {
        Ordem = ordem;
        EstabelecimentoId = estabelecimentoId;
        Dia = dia;
        HorarioAbertura = horarioAbertura;
        HorarioEncerramento = horarioEncerramento;

        ValidarEntidade();
    }

    public override void ValidarEntidade()
    {
        ExcecaoValidacaoEntidade.Quando(Dia < DiasSemanais.SegundaFeira || Dia > DiasSemanais.Domingo, "O dia da semana informado não é válido!");

        ExcecaoValidacaoEntidade.Quando(HorarioAbertura >= HorarioEncerramento, "O horário de abertura deve ser menor que o horário de encerramento!"); 
    }
}
