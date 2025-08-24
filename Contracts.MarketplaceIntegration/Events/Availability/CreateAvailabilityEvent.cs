
using Contracts.MarketplaceIntegration.DTO;
using Contracts.MarketplaceIntegration.Enum;

namespace Contracts.MarketplaceIntegration.Events.Availability;

/// <summary>
/// Event triggered when a new availability schedule is created for a resource in the marketplace.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item><description>Contains the unique identifier of the availability entry.</description></item>
/// <item><description>Identifies the resource associated with this availability.</description></item>
/// <item><description>Specifies the type of the resource (e.g., VM, Dedicated).</description></item>
/// <item><description>Includes a list of time slots defining when the resource is available.</description></item>
/// </list>
/// </remarks>
public record CreateAvailabilityEvent
{
    public Guid AvailabilityId { get; set; }
    public Guid ResourceId { get; init; }
    public ResourceType Type { get; init; }
    public List<AvailabilitySlotDto> Slots { get; init; } = [];
}