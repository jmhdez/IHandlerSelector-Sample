using System;
using System.Linq;
using Castle.MicroKernel;
using HSSample.Services;

namespace HSSample.Infrastructure
{
    public class ModulesHandlerSelector : IHandlerSelector
    {
        private readonly IModuleConfiguration configuration;

        public ModulesHandlerSelector(IModuleConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public bool HasOpinionAbout(string key, Type service)
        {
            return service.IsInAppModule();
        }

        public IHandler SelectHandler(string key, Type service, IHandler[] handlers)
        {
            var module = service.GetAppModule();

            if (configuration.IsActive(module))
                return handlers.First(x => x.ComponentModel.Implementation.IsNotNullImplementation());

            return handlers.First(x => x.ComponentModel.Implementation.IsNullImplementation());
        }
    }
}