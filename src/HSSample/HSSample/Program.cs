using System;
using Castle.Windsor;
using Castle.Windsor.Installer;
using HSSample.Infrastructure;
using HSSample.Modules.Email;
using HSSample.Services;

namespace HSSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Install(FromAssembly.This());

            Console.Out.WriteLine(typeof (EmailSender).IsInAppModule());

            var service = container.Resolve<IReportService>();
            service.GenerateReport("c3p0");

            Console.Out.WriteLine("Press <ENTER> to exit");
            Console.In.ReadLine();
        }
    }
}
