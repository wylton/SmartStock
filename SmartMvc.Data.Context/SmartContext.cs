using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SmartMvc.Data.Context.Config;
using SmartMvc.Data.Context.Mapping;
using SmartMvc.Domain.Entities;

namespace SmartMvc.Data.Context
{
    public class SmartContext : BaseDbContext
    {
        static SmartContext()
        {
            //Database.SetInitializer(new ContextInitializer());
        }

        public SmartContext()
            : base("SmartEntities")
        {
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BoxMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new MovimentBoxMap());
            modelBuilder.Configurations.Add(new MovimentItemMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new UserMap());

        }

        #region DbSet

        public DbSet<Box> Boxes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<MovimentBox> MovimentBoxes { get; set; }
        public DbSet<MovimentItem> MovimentItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion
    }
}