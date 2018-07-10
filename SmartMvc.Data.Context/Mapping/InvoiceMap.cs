using SmartMvc.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SmartMvc.Data.Context.Mapping
{
    public class InvoiceMap : EntityTypeConfiguration<Invoice>
    {
        public InvoiceMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Emission)
                .IsRequired();

            Property(t => t.Filial)
                .IsRequired();

            Property(t => t.KeyNf)
                .HasMaxLength(44)
                .IsRequired();

            Property(t => t.NumberInvoice)
                .HasMaxLength(15)
                .IsRequired();

            Property(t => t.NumberSerieInvoice)
                .HasMaxLength(6)
                .IsRequired();

            Property(t => t.Quantity)
                .IsRequired();

            Property(t => t.Type)
                .HasMaxLength(25)
                .IsRequired();

            Property(t => t.Volume)
                .IsRequired();

            HasMany(x => x.MovimentBoxes)
                .WithRequired(x => x.Invoice);

            Ignore(t => t.ValidationResult);
        }
    }
}
