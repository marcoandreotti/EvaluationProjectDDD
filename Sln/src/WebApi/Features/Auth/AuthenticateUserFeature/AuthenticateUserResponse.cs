using Domain.Contracts;

namespace WebApi.Features.Auth.AuthenticateUserFeature;

/// <summary>
/// Represents the response returned after user authentication
/// </summary>
public sealed class AuthenticateUserResponse: UserContract
{
    /// <summary>
    /// Gets or sets the JWT token for authenticated user
    /// </summary>
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the user's unique identifier
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the user's role in the system
    /// </summary>
    public string Role { get; set; } = string.Empty;
}
