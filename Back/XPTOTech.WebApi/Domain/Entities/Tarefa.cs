using static XPTOTech.WebApi.Domain.Enums.Enums;

namespace XPTOTech.WebApi.Domain.Entities
{
    public class Tarefa : Base
    {
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public int ResponsavelId { get; set; }
        public bool PrioridadeAlta { get; set; } = false;
        public float TempoEstimado { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataConclusao { get; set; }
        public StatusEnum Status { get; set; }
        public Usuario? Responsavel { get; set; }
    }
}
