namespace Core.CleanArchitecture.Application.UseCases.CreateUser
{
    public sealed class CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;
}