namespace Contracts.MarketplaceIntegration.Events.Notification;

/// <summary>
/// Event emitted when a notification is marked as read.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item><description>Contains the identifier of the notification marked as read.</description></item>
/// <item><description>Used to synchronize read status across services and update UI.</description></item>
/// </list>
/// </remarks>
public record NotificationReadEvent
{
    /// <summary>
    /// Unique identifier of the notification marked as read.
    /// </summary>
    public string NotificationId { get; init; } = null!;
}