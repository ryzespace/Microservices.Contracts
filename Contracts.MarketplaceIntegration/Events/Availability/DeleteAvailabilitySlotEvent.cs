using Contracts.MarketplaceIntegration.Enum;

namespace Contracts.MarketplaceIntegration.Events.Availability;

/// <summary>
/// Event triggered when a single availability slot is deleted from a resource in the marketplace.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item><description>Specifies the parent availability entry from which the slot will be removed.</description></item>
/// <item><description>Indicates the type of the resource (e.g., VM, Dedicated) for proper identification.</description></item>
/// <item><description>Identifies the specific slot to delete within the availability schedule.</description></item>
/// </list>
/// </remarks>
public record DeleteAvailabilitySlotEvent
{
    public Guid AvailabilityId { get; set; }
    public ResourceType Type { get; init; }
    public Guid SlotId { get; set; }
}