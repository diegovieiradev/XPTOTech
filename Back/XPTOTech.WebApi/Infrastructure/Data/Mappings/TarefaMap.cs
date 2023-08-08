using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XPTOTech.WebApi.Domain.Entities;

namespace XPTOTech.WebApi.Infrastructure.Data.Mappings
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("tarefa");

            builder.Property(x => x.Titulo)
                .HasColumnName("titulo")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Descricao)
                .HasColumnName("descricao")
                .HasMaxLength(500);

            builder.Property(x => x.PrioridadeAlta)
                .HasColumnName("prioridade_alta")
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.TempoEstimado)
                .HasColumnName("tempo_estimado");

            builder.Property(x => x.DataInicio)
                .HasColumnName("data_inicio")
                .IsRequired();

            builder.Property(x => x.DataConclusao)
                .HasColumnName("data_conclusao");

            builder.Property(x => x.Status)
                .HasColumnName("status")
                .IsRequired();

            builder.Property(x => x.ResponsavelId)
                .HasColumnName("id_responsavel")
                .IsRequired();

            builder.HasOne(r => r.Responsavel)
                .WithMany()
                .HasForeignKey(r => r.ResponsavelId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
