using System;

namespace ConDev.Logic
{
    public interface IOnUserCreated
    {
        Guid Id { get;  }
        string Email { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}