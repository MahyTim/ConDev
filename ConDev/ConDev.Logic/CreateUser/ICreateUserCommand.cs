using System;

namespace ConDev.Logic.CreateUser
{
    public interface ICreateUserCommand
    {
        CreateUserResult TryCreate(ICreateUserCommandInput input);
    }

    public class CreateUserResult
    {
        public Guid? Id { get; internal set; }
        public ValidationFailedErrors? ValidationFailed { get; internal set; }

        public static CreateUserResult Success(Guid id)
        {
            return new CreateUserResult()
            {
                Id = id,
            };
        }

        public static CreateUserResult Failed(ValidationFailedErrors validationFailed)
        {
            return new CreateUserResult()
            {
                ValidationFailed = validationFailed
            };
        }

        private CreateUserResult() { } // Show


        public enum ValidationFailedErrors
        {
            FailedDuplicateEmail = 501
        }
    }

   
}