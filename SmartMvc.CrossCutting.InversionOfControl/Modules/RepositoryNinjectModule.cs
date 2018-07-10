using SmartMvc.Data.Repository.EntityFramework.Common;
using SmartMvc.Domain.Interfaces.Repository.Common;
using Ninject.Modules;
using SmartMvc.Domain.Interfaces.Repository;
using SmartMvc.Data.Repository.EntityFramework;
using SmartMvc.Data.Repository.Dapper;
using SmartMvc.Domain.Entities;
using SmartMvc.Domain.Interfaces.Repository.ReadOnly;

namespace SmartMvc.CrossCutting.InversionOfControl.Modules
{
    public class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof (IRepository<>)).To(typeof (Repository<>));

            Bind<IBoxRepository>().To<BoxRepository>();
            Bind<IBoxReadOnlyRepository>().To<BoxDapperRepository>();
            Bind<IReadOnlyRepository<Box>>().To<BoxDapperRepository>();

            Bind<IMovimentBoxRepository>().To<MovimentBoxRepository>();
            Bind<IMovimentBoxReadOnlyRepository>().To<MovimentBoxDapperRepository>();
            Bind<IReadOnlyRepository<MovimentBox>>().To<MovimentBoxDapperRepository>();

            Bind<IDepartmentRepository>().To<DepartmentRepository>();
            Bind<IDepartmentReadOnlyRepository>().To<DepartmentDapperRepository>();
            Bind<IReadOnlyRepository<Department>>().To<DepartmentDapperRepository>();

            Bind<IInvoiceRepository>().To<InvoiceRepository>();
            Bind<IInvoiceReadOnlyRepository>().To<InvoiceDapperRepository>();
            Bind<IReadOnlyRepository<Invoice>>().To<InvoiceDapperRepository>();

            Bind<IMovimentItemRepository>().To<MovimentItemRepository>();
            Bind<IMovimentItemReadOnlyRepository>().To<MovimentItemDapperRepository>();
            Bind<IReadOnlyRepository<MovimentItem>>().To<MovimentItemDapperRepository>();

            Bind<IUserRepository>().To<UserRepository>();
            Bind<IUserReadOnlyRepository>().To<UserDapperRepository>();
            Bind<IReadOnlyRepository<User>>().To<UserDapperRepository>();
        }
    }
}
