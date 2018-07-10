using SmartMvc.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SmartMvc.Data.Context.Mapping
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .IsRequired();


            Ignore(t => t.ValidationResult);
        }
    }
}
