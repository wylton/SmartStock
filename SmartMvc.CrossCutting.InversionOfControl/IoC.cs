﻿using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using SmartMvc.CrossCutting.InversionOfControl.Modules;
using Ninject;

namespace SmartMvc.CrossCutting.InversionOfControl
{
    public class IoC
    {
        public IKernel Kernel { get; private set; }

        public IoC()
        {
            Kernel = GetNinjectModules();
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(Kernel));
        }

        public StandardKernel GetNinjectModules()
        {
            return new StandardKernel(
                new ServiceNinjectModule(),
                new InfrastructureNinjectModule(),
                new RepositoryNinjectModule(),
                new ApplicationNinjectModule());
        }
    }
}
