namespace Contracts.MarketplaceIntegration.DTO;

/// <summary>
/// Represents a time slot for resource availability in the marketplace.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item><description>Defines the day of the week.</description></item>
/// <item><description>Specifies the start time in <c>HH:mm</c> format.</description></item>
/// <item><description>Specifies the end time in <c>HH:mm</c> format.</description></item>
/// </list>
/// </remarks>
public class AvailabilitySlotDto
{
    /// <summary>
    /// Day of the week (e.g. "MON", "TUE", etc.).
    /// </summary>
    public string DayOfWeek { get; set; } = string.Empty;

    /// <summary>
    /// Start time in HH:mm format.
    /// </summary>
    public string StartTime { get; set; } = string.Empty;

    /// <summary>
    /// End time in HH:mm format.
    /// </summary>
    public string EndTime { get; set; } = string.Empty;
}