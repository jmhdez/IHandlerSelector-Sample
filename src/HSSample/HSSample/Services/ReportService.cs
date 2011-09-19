using System;
using System.IO;
using HSSample.Modules.Email;
using HSSample.Modules.Security;

namespace HSSample.Services
{
    public class ReportService : IReportService
    {
        private readonly IAuditLog auditLog;
        private readonly IEmailSender emailSender;

        public ReportService(IAuditLog auditLog, IEmailSender emailSender)
        {
            this.auditLog = auditLog;
            this.emailSender = emailSender;
        }

        public void GenerateReport(string currentUser)
        {
            Console.Out.WriteLine("Generating report for user {0}", currentUser);

            var report = new Report("Sample Report",
                                    string.Format("This is a sample report for {0} generated at {1:HH:mm}",
                                                  currentUser,
                                                  DateTime.Now));

            Console.Out.WriteLine("Report generated:");
            Console.Out.WriteLine(report);

            emailSender.Send(report);
            auditLog.RegisterAccess(currentUser, report);
        }
    }
}