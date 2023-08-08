using AutoMapper;
using XPTOTech.WebApi.Application.Repositories;

namespace XPTOTech.WebApi.Application.Usercases.Tarefa
{
    public class DeleteTarefaUserCase : UserCaseBase<int, bool>
    {
        readonly ITarefaRepository _tarefaRepository;

        public DeleteTarefaUserCase(ITarefaRepository tarefaRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
            _tarefaRepository = tarefaRepository;
        }

        protected override async Task<bool> OnHandle(int id)
        {
            await _tarefaRepository.DeleteAsync(id);

            return true;
        }
    }
}
