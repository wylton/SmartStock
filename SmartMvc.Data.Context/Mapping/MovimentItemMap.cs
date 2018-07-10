using SmartMvc.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SmartMvc.Data.Context.Mapping
{
    public class MovimentItemMap : EntityTypeConfiguration<MovimentItem>
    {
        public MovimentItemMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            HasRequired(x => x.MovimentBox);
            HasRequired(x => x.Box);

            Ignore(t => t.ValidationResult);
        }
    }
}
