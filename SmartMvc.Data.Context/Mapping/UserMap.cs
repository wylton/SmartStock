using SmartMvc.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SmartMvc.Data.Context.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .IsRequired();

            Property(t => t.Login)
                .IsRequired();

            Property(t => t.Password)
                .IsRequired();

            Property(t => t.IsAdmin)
                .IsRequired();

            Property(t => t.DateCreate)
                .IsRequired();


            Ignore(t => t.ValidationResult);
        }
    }
}
