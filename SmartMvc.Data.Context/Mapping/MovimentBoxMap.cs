using SmartMvc.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SmartMvc.Data.Context.Mapping
{
    public class MovimentBoxMap : EntityTypeConfiguration<MovimentBox>
    {
        public MovimentBoxMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.TypeMoviment)
                .IsRequired();

            Property(t => t.InitialDate)
                .IsRequired();

            Property(t => t.FinalDate)
                .IsOptional();

            HasRequired(x => x.Invoice);

            HasMany(x => x.MovimentItems)
                .WithRequired(x => x.MovimentBox);

            Ignore(t => t.ValidationResult);
        }
    }
}
