using System;

namespace HSSample.Modules.Email
{
    public class EmailSender : IEmailSender
    {
        public void Send(Report report)
        {
            Console.Out.WriteLine();
            Console.Out.WriteLine("EmailSender::Sending report '{0}'", report.Title);
            Console.Out.WriteLine();
        }
    }
}