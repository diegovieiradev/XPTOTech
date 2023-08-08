namespace XPTOTech.WebApi.Domain.Dtos.Tarefa
{
    public class TarefaListDto
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public bool PrioridadeAlta { get; set; }
        public string? Status { get; set; }
        public string? Responsavel { get; set; }
    }
}
