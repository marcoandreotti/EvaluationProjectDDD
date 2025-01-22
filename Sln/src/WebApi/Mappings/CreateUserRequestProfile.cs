using Application.Users.CreateUser;
using AutoMapper;
using WebApi.Features.Users.CreateUser;

namespace WebApi.Mappings;

public class CreateUserRequestProfile : Profile
{
    public CreateUserRequestProfile()
    {
        CreateMap<CreateUserRequest, CreateUserCommand>();
    }
}