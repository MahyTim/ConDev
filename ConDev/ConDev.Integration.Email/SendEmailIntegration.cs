using System;
using ConDev.Logic;
using ConDev.Logic.Integrations;

namespace ConDev.Integration.Email
{
    public class SendEmailIntegration : IOutputIntegration
    {
        public void OnUserCreated(IOnUserCreated onUserCreated)
        {
            Console.WriteLine($"Send to email {onUserCreated.Email}");
        }
    }
}