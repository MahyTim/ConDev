using System;
using System.Collections.Generic;

namespace ConDev.Logic.CreateUser
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private IUserRepository _userRepository;
        private readonly IEnumerable<IOutputIntegration> _integrations;
        private readonly Lazy<SlowStartup> _slowStartup;

        public CreateUserCommand(IUserRepository userRepository,
            IEnumerable<IOutputIntegration> integrations,
            Lazy<SlowStartup> slowStartup)
        {
            _userRepository = userRepository;
            _integrations = integrations;
            _slowStartup = slowStartup;
        }

        public CreateUserResult TryCreate(ICreateUserCommandInput input)
        {
            if (input.Email.EndsWith("test.be", StringComparison.OrdinalIgnoreCase))
            {
                _slowStartup.Value.Execute(input.Email);
            }

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