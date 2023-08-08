namespace XPTOTech.WebApi.Domain.Entities
{
    public class EntityHasDependecyException : Exception
    {
        public EntityHasDependecyException() : base("O registro não pôde ser excluído, porque já está em uso em outro(s) locai(s) da aplicação.")
        {
            HResult = 547;
        }
    }
}
