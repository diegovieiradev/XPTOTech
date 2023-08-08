using System.ComponentModel;
using System.Text.Json.Serialization;

namespace XPTOTech.WebApi.Domain.Enums
{
    public class Enums
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum StatusEnum
        {
            [Description("Pendente")]
            PENDENTE,

            [Description("Em Andamento")]
            EM_ANDAMENTO,

            [Description("Concluída")]
            CONCLUIDA,

            [Description("Cancelada")]
            CANCELADA
        }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum CargosEnum
        {
            [Description("Desenvolvedore")]
            DESENVOLVEDOR,

            [Description("Designer")]
            DESIGNER,

            [Description("Gerente de Projeto")]
            GERENTE_PROJETO,

            [Description("Analista de Qualidade")]
            ANALISTA_QUALIDADE
        }
    }
}
