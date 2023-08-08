using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XPTOTech.WebApi.Domain.Entities;

namespace XPTOTech.WebApi.Infrastructure.Data.Mappings
{
    public class BaseMap<T> : IEntityTypeConfiguration<T> where T : Base
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedNever().IsRequired();
            builder.Property(x => x.DataAlteracao).HasColumnName("data_alteracao").HasDefaultValue();
            builder.Property(x => x.DataCriacao).HasColumnName("data_criacao").IsRequired().HasDefaultValue();
        }
    }
}
