namespace XPTOTech.WebApi.Domain.Dtos.Tarefa
{
    public class TarefaFilterDto
    {
        public string? Titulo { get; set; }
        public bool PrioridadeAlta { get; set; }
        public string? Status { get; set; }
        public string? Responsavel { get; set; }
    }
}
