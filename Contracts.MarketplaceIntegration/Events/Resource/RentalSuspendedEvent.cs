namespace Contracts.MarketplaceIntegration.Events.Resource;

/// <summary>
/// Event emitted when a rental offer is suspended in the marketplace.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item><description>Emitted by the marketplace service when an offer is blocked or hidden from customers.</description></item>
/// <item><description>Common reasons: policy violations, fraud suspicion, or technical issues.</description></item>
/// <item><description>Receivers should update the rental status to <c>Suspended</c> and prevent further bookings.</description></item>
/// </list>
/// </remarks>
public record RentalSuspendedEvent
{
    /// <summary>
    /// Unique identifier of the rental offer.
    /// </summary>
    public Guid RentalId { get; init; }

    /// <summary>
    /// Reason for the suspension.
    /// </summary>
    public string Reason { get; init; } = null!;

    /// <summary>
    /// Date and time when the suspension took place (UTC).
    /// </summary>
    public DateTime SuspendedAt { get; init; }
}
