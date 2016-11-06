using System;
using Hangfire;

namespace HangfireDemo
{
    class Program
    {
        static void Main()
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("Server=(localdb)\\MSSQLLocalDB;Integrated Security=true");


            using (var server = new BackgroundJobServer(new BackgroundJobServerOptions { ServerName = "ConsoleServer" }))
            {
                Console.WriteLine("Hangfire Server started. Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
