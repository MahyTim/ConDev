namespace ConDev.Logic
{
    public interface IUserRepository
    {
        User Insert(User user);
        bool EmailExists(string email);
    }

    
}