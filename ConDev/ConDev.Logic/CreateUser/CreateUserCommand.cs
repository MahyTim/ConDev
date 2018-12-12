using System;
using System.Collections.Generic;
using ConDev.Logic.Integrations;

namespace ConDev.Logic.CreateUser
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private IUserRepository _userRepository;
        private readonly IEnumerable<IOutputIntegration> _integrations;

        public CreateUserCommand(IUserRepository userRepository,IEnumerable<IOutputIntegration> integrations)
        {
            _userRepository = userRepository;
            _integrations = integrations;
        }

        public CreateUserResult TryCreate(ICreateUserCommandInput input)
        {
            if (_userRepository.EmailExists(input.Email))
                return CreateUserResult.Failed(CreateUserResult.ValidationFailedErrors.FailedDuplicateEmail);

            var user = _userRepository.Insert(new User()
            {
                Email = input.Email,
                FirstName = input.FirstName,
                Id = Guid.NewGuid(),
                LastName = input.LastName
            });

            foreach(var integration in _integrations)
            {
                integration.OnUserCreated(user);
            }

            return CreateUserResult.Success(user.Id);
        }
    }
}