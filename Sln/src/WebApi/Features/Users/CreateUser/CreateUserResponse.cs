using Domain.Contracts;
using Domain.Enums;

namespace WebApi.Features.Users.CreateUser;

/// <summary>
/// API response model for CreateUser operation
/// </summary>
public class CreateUserResponse : UserContract
{
    /// <summary>
    /// The unique identifier of the created user
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The user's role in the system
    /// </summary>
    public UserRole Role { get; set; }

    /// <summary>
    /// The current status of the user
    /// </summary>
    public UserStatus Status { get; set; }
}
