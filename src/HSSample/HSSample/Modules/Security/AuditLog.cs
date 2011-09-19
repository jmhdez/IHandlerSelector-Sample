using System;

namespace HSSample.Modules.Security
{
    public class AuditLog : IAuditLog
    {
        public void RegisterAccess(string user, Report report)
        {
            Console.WriteLine();
            Console.Out.WriteLine("AuditLog::User {0} has generated the report '{1}'",
                                  user,
                                  report.Title);
            Console.WriteLine();
        }
    }
}