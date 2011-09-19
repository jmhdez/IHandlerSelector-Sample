using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSSample.Modules.Security
{
    public interface IAuditLog
    {
        void RegisterAccess(string user, Report report);
    }
}
