using System;

namespace ConDev.Logic.Integrations
{
    public interface IOnUserCreated
    {
        Guid Id { get; }
        string Email { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}