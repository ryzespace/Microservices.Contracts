using Contracts.MarketplaceIntegration.DTO;

namespace Contracts.MarketplaceIntegration.Events;

/// <summary>
/// Raised when the availability schedule for a resource is updated.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Emitted when any slot changes occur.</item>
/// <item>Used to synchronize availability state between Seller and Marketplace.</item>
/// </list>
/// </remarks>
public record ResourceAvailabilityUpdatedEvent
{
    /// <summary>
    /// Resource identifier.
    /// </summary>
    public Guid ResourceId { get; init; }

    /// <summary>
    /// List of availability slots for the resource.
    /// </summary>
    public IReadOnlyList<AvailabilitySlotDto> Slots { get; init; } = [];

    /// <summary>
    /// Event creation timestamp.
    /// </summary>
    public DateTimeOffset OccurredAt { get; init; }
}