namespace Contracts.MarketplaceIntegration.DTO;

/// <summary>
/// Represents a notification sent to a seller in the marketplace.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item><description>Contains a unique identifier for the notification.</description></item>
/// <item><description>Stores the notification title and message.</description></item>
/// <item><description>Indicates whether the notification has been read.</description></item>
/// <item><description>Includes the UTC creation timestamp.</description></item>
/// </list>
/// </remarks>
public class NotificationDto
{
    /// <summary>
    /// Unique notification identifier.
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// Notification title displayed to the seller.
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Main notification message.
    /// </summary>
    public string Message { get; set; } = null!;

    /// <summary>
    /// Whether the notification has been read by the seller.
    /// </summary>
    public bool IsRead { get; set; }

    /// <summary>
    /// UTC timestamp when the notification was created.
    /// </summary>
    public DateTime CreatedAtUtc { get; set; }
}