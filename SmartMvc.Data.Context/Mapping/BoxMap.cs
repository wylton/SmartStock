using SmartMvc.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SmartMvc.Data.Context.Mapping
{
    public class BoxMap : EntityTypeConfiguration<Box>
    {
        public BoxMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .IsOptional();

            Property(t => t.DatePrinter)
                .IsRequired();

            Property(t => t.DateChecked)
                .IsOptional();

            HasMany(x => x.MovimentItems)
                .WithRequired(x => x.Box);

            Ignore(t => t.ValidationResult);
        }
    }
}
