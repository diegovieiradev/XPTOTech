using AutoMapper;
using XPTOTech.WebApi.Application.Repositories;
using XPTOTech.WebApi.Domain.Dtos.Tarefa;
using TarefaModel = XPTOTech.WebApi.Domain.Entities.Tarefa;

namespace XPTOTech.WebApi.Application.Usercases.Tarefa
{
    public class CreateTarefaUserCase : UserCaseBase<TarefaCreateDto, bool>
    {
        readonly ITarefaRepository _tarefaRepository;

        public CreateTarefaUserCase(ITarefaRepository tarefaRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
            _tarefaRepository = tarefaRepository;
        }

        protected override async Task<bool> OnHandle(TarefaCreateDto param)
        {
            var tarefa = _mapper.Map<TarefaModel>(param);

            await _tarefaRepository.CreateAsync(tarefa);

            return true;
        }
    }
}
