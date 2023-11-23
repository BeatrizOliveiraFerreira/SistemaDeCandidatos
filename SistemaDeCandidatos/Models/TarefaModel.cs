using SistemaDeCandidatos.enums;

namespace SistemaDeCandidatos.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set;}
        public string? Descricao { get; set; }
        public int? CPF { get; set; }
        public StatusTarefa Status { get; set; }
    }
}
