namespace HSSample.Modules.Email
{
    public class NullEmailSender : IEmailSender
    {
        public void Send(Report report)
        {
            // Nothing to do here. This is a *Null*EmailSender
        }
    }
}