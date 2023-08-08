using static XPTOTech.WebApi.Domain.Enums.Enums;
using XPTOTech.WebApi.Domain.Entities;

namespace XPTOTech.WebApi.Domain.Dtos.Tarefa
{
    public class TarefaUpdateDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public bool PrioridadeAlta { get; set; } = false;
        public float TempoEstimado { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataConclusao { get; set; }
        public StatusEnum Status { get; set; }
        public int IdResponsavel { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public Usuario? Responsavel { get; set; }
    }
}
