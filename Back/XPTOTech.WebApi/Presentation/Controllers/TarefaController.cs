using Microsoft.AspNetCore.Mvc;
using XPTOTech.WebApi.Domain.Entities;
using XPTOTech.WebApi.Infrastructure.Data;

namespace XPTOTech.WebApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : Controller
    {
        readonly XPTOTechContext _xPTOTechContext;

        public TarefaController(XPTOTechContext xPTOTechContext)
        {
            _xPTOTechContext = xPTOTechContext;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_xPTOTechContext.Tarefas.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id) 
        {
            var tarefa = _xPTOTechContext.Tarefas.SingleOrDefault(x => x.Id == id);

            if (tarefa == null)
            {
                return NotFound("Tarefa não encontrada!");
            }

            return Ok(tarefa);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var tarefa = _xPTOTechContext.Tarefas.FirstOrDefault(x => x.Id == id);

            if (tarefa == null)
            {
                return NotFound();
            }

            _xPTOTechContext.Tarefas.Remove(tarefa);
            _xPTOTechContext.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id, DataCriacao, DataAlteracao, Titulo, Descricao, " +
            "PrioridadeAlta, TempoEstimado, DataInicio, DataConclusao, Status, Responsavel")] Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                _xPTOTechContext.Add(tarefa);
                _xPTOTechContext.SaveChanges();

                return NoContent();
            }

            return NotFound();
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = _xPTOTechContext.Tarefas.Find(id);

            if (tarefa == null)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
