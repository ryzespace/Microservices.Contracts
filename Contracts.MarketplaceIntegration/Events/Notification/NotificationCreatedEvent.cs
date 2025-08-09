using Contracts.MarketplaceIntegration.DTO;

namespace Contracts.MarketplaceIntegration.Events.Notification;

/// <summary>
/// Event emitted when a new notification is created for a seller.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item><description>Contains full details of the notification.</description></item>
/// <item><description>Used by downstream services to notify the seller or update UI.</description></item>
/// </list>
/// </remarks>
public record NotificationCreatedEvent
{
    /// <summary>
    /// Notification details.
    /// </summary>
    public NotificationDto Notification { get; init; } = null!;
}