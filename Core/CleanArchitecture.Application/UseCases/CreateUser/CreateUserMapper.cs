using AutoMapper;
using Core.CleanArchitecture.Domain.Entities;

namespace Core.CleanArchitecture.Application.UseCases.CreateUser
{
    public sealed class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreateUserResponse>();
        }
    }
}