using System.Collections.Generic;
using System.Text;

namespace ConDev.Logic
{
    public interface IOutputIntegration
    {
        void OnUserCreated(IOnUserCreated onUserCreated);
    }
}
