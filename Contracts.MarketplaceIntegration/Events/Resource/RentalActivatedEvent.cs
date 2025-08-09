namespace Contracts.MarketplaceIntegration.Events.Resource;

/// <summary>
/// Event emitted when a previously suspended rental offer is reactivated in the marketplace.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item><description>Emitted by the marketplace service when an offer becomes available again for booking.</description></item>
/// <item><description>Often follows a <see cref="RentalSuspendedEvent"/> after the issue is resolved.</description></item>
/// <item><description>Receivers should update the rental status to <c>Active</c> and restore availability in the system.</description></item>
/// </list>
/// </remarks>
public record RentalActivatedEvent
{
    /// <summary>
    /// Unique identifier of the rental offer.
    /// </summary>
    public Guid RentalId { get; init; }

    /// <summary>
    /// Date and time when the activation took place (UTC).
    /// </summary>
    public DateTime ActivatedAt { get; init; }
}