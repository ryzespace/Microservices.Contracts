using Contracts.MarketplaceIntegration.DTO;
using Contracts.MarketplaceIntegration.Enum;

namespace Contracts.MarketplaceIntegration.Events.Availability;

/// <summary>
/// Event triggered when an existing availability schedule is updated for a resource in the marketplace.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item><description>Identifies the availability entry being updated.</description></item>
/// <item><description>Includes the resource identifier and type associated with this availability.</description></item>
/// <item><description>Contains the updated list of slots. Unchanged slots should remain intact, only modified ones are replaced.</description></item>
/// <item><description>Supports partial updates (e.g., only one slot updated while others stay the same).</description></item>
/// </list>
/// </remarks>
public record UpdateAvailabilityEvent
{
    public Guid AvailabilityId { get; init; }
    public Guid ResourceId { get; init; }
    public ResourceType Type { get; init; }
    public List<AvailabilitySlotDto> Slots { get; init; } = [];
}