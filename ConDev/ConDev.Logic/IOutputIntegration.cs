using System;
using System.Collections.Generic;
using System.Text;

namespace ConDev.Logic
{
    public interface IOutputIntegration
    {
        void OnUserCreated(IOnUserCreated onUserCreated);
    }

    public interface IOnUserCreated
    {
        Guid Id { get;  }
        string Email { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
