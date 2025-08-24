namespace Contracts.MarketplaceIntegration.Events.Availability;

/// <summary>
/// Event triggered when an existing availability entry is deleted from the marketplace.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item><description>Contains the unique identifier of the availability entry to be deleted.</description></item>
/// <item><description>This event allows downstream services (e.g., Seller) to remove or deactivate the availability.</description></item>
/// </list>
/// </remarks>
public record DeleteAvailabilityEvent
{
    public Guid AvailabilityId { get; set; }
}