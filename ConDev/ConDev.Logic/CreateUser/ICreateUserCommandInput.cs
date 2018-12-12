namespace ConDev.Logic.CreateUser
{
    public interface ICreateUserCommandInput // Show
    {
        string Email { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}