using Domain.Contracts;
using Domain.Enums;

namespace WebApi.Features.Users.CreateUser;

/// <summary>
/// Represents a request to create a new user in the system.
/// </summary>
public class CreateUserRequest: UserContract
{
    /// <summary>
    /// Gets or sets the password. Must meet security requirements.
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the initial status of the user account.
    /// </summary>
    public UserStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the role assigned to the user.
    /// </summary>
    public UserRole Role { get; set; }
}