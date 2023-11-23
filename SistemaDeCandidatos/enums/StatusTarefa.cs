using System.ComponentModel;

namespace SistemaDeCandidatos.enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        Afazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluído")]
        Concluído = 3,
    }
}
