using System.Collections.Generic;

namespace HSSample.Services
{
    public class ModuleConfiguration : IModuleConfiguration
    {
        private readonly IDictionary<string, bool> activeModules;

        public ModuleConfiguration()
        {
            // TODO: This should be read from external configuration, be dependant on current license... whatever.

            activeModules = new Dictionary<string, bool>
                                {
                                    {"Email", true},
                                    {"Security", false}
                                };
        }

        public bool IsActive(string module)
        {
            return activeModules[module];
        }
    }
}