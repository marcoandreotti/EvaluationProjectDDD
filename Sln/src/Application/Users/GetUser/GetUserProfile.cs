using AutoMapper;
using Domain.Entities;

namespace Application.Users.GetUser;

/// <summary>
/// Profile for mapping between User entity and GetUserResponse
/// </summary>
public class GetUserProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetUser operation
    /// </summary>
    public GetUserProfile()
    {
        CreateMap<User, GetUserResult>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Username));

    }
}
