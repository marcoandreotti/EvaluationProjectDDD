namespace Domain.Contracts;

public class UserContract
{
    /// <summary>
    /// Common property that gets or sets the full name..
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Common property that gets or sets the username..
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Common property that gets or sets the phone number.
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Common property that gets or sets the email address.
    /// </summary>
    public string Email { get; set; } = string.Empty;
}
