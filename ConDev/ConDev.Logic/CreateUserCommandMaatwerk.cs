using System;
using ConDev.Logic.CreateUser;

namespace ConDev.Logic
{
    public class CreateUserCommandMaatwerk : ICreateUserCommand
    {
        private readonly ICreateUserCommand _inner;

        public CreateUserCommandMaatwerk(ICreateUserCommand inner)
        {
            _inner = inner;
        }

        public CreateUserResult TryCreate(ICreateUserCommandInput input)
        {
            if (input.Email.EndsWith(ModifiedInput.DomainToReplace, StringComparison.OrdinalIgnoreCase))
            {
                return _inner.TryCreate(new ModifiedInput(input));
            }
            else
            {
                return _inner.TryCreate(input);
            }

        }

        class ModifiedInput : ICreateUserCommandInput
        {
            public const string DomainToReplace = "tester.be";

            private readonly ICreateUserCommandInput _input;

            public ModifiedInput(ICreateUserCommandInput input)
            {
                _input = input;
            }
            public string Email => _input.Email.Replace(DomainToReplace, "tester.corp.be", StringComparison.OrdinalIgnoreCase);
            public string FirstName => _input.FirstName;
            public string LastName => _input.LastName;
        }
    }
}