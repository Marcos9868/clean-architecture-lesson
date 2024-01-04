using FluentValidation;

namespace Core.CleanArchitecture.Application.UseCases.CreateUser
{
    public class CreateUserValidator : AbstractValidator<CreateUserRequest>;
    {
        public CreateUserValidator()
        {
            RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(70);
        }
    }
}