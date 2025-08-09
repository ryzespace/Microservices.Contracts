namespace Contracts.MarketplaceIntegration.Events.Notification;

/// <summary>
/// Event emitted when a notification is deleted.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item><description>Contains the identifier of the deleted notification.</description></item>
/// <item><description>Used by services to update UI and data stores accordingly.</description></item>
/// </list>
/// </remarks>
public record NotificationDeletedEvent
{
    /// <summary>
    /// Unique identifier of the deleted notification.
    /// </summary>
    public string NotificationId { get; init; } = null!;
}