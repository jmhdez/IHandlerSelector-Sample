using System;
using System.Linq;
using System.Text;

namespace HSSample.Services
{
    public interface IModuleConfiguration
    {
        bool IsActive(string module);
    }
}
