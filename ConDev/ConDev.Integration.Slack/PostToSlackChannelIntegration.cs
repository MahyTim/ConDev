using System;
using ConDev.Logic;

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
