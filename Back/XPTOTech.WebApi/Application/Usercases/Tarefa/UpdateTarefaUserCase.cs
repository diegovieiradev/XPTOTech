using AutoMapper;
using XPTOTech.WebApi.Application.Repositories;
using XPTOTech.WebApi.Domain.Dtos.Tarefa;
using TarefaModel = XPTOTech.WebApi.Domain.Entities.Tarefa;

namespace XPTOTech.WebApi.Application.Usercases.Tarefa
{
    public class UpdateTarefaUserCase : UserCaseBase<TarefaUpdateDto, bool>
    {
        readonly ITarefaRepository _tarefaRepository;

        public UpdateTarefaUserCase(ITarefaRepository tarefaRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
            _tarefaRepository = tarefaRepository;
        }

        protected override async Task<bool> OnHandle(TarefaUpdateDto param)
        {
            var tarefa = _mapper.Map<TarefaModel>(param);

            await _tarefaRepository.UpdateAsync(tarefa.Id, tarefa, new List<string>());

            return true;
        }
    }
}
