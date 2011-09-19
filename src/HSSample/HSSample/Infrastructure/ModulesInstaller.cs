using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using HSSample.Services;

namespace HSSample.Infrastructure
{
    public class ModulesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                                   .Where(x => x.IsInAppModule())
                                   .WithService.DefaultInterfaces());

            container.Kernel.AddHandlerSelector(new ModulesHandlerSelector(new ModuleConfiguration()));
        }
    }
}
