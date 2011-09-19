namespace HSSample.Modules.Security
{
    public class NullAuditLog : IAuditLog
    {
        public void RegisterAccess(string user, Report report)
        {
            // Nothing to do here. This is a *Null*AuditLog
        }
    }
}