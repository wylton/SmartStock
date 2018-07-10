using SmartMvc.Data.Context;
using SmartMvc.Data.Context.Interfaces;
using Ninject.Modules;

namespace SmartMvc.CrossCutting.InversionOfControl.Modules
{
    public class InfrastructureNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbContext>().To<SmartContext>();
            Bind(typeof (IContextManager<>)).To(typeof (ContextManager<>));
            Bind(typeof(IUnitOfWork<>)).To((typeof(UnitOfWork<>)));
        }
    }
}
