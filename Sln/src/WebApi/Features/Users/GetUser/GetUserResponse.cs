using Domain.Contracts;

namespace WebApi.Features.Users.GetUser;

/// <summary>
/// API response model for GetUser operation
/// </summary>
public class GetUserResponse: UserContract
{
    /// <summary>
    /// The unique identifier of the user
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The user's role in the system
    /// </summary>
    public string Role { get; set; } = string.Empty;

    /// <summary>
    /// The current status of the user
    /// </summary>
    public string Status { get; set; } = string.Empty;
}
