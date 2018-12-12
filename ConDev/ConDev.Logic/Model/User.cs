using System;
using ConDev.Logic.Integrations;

namespace ConDev.Logic
{
    public class User : IOnUserCreated
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
