using static XPTOTech.WebApi.Domain.Enums.Enums;

namespace XPTOTech.WebApi.Domain.Entities
{
    public class Usuario : Base
    {
        public string Nome { get; set; } = string.Empty;
        public CargosEnum Cargo { get; set; }
    }
}
