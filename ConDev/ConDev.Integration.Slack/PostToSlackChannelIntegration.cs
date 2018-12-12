using System;
using ConDev.Logic;
using ConDev.Logic.Integrations;

namespace ConDev.Integration.Slack
{
    public class PostToSlackChannelIntegration : IOutputIntegration
    {
        public void OnUserCreated(IOnUserCreated onUserCreated)
        {
            Console.WriteLine($"Posted to slack: {onUserCreated.Email}");
        }
    }
}
