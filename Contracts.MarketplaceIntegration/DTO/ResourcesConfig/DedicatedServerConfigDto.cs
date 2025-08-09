namespace Contracts.MarketplaceIntegration.DTO.ResourcesConfig;

/// <summary>
/// Configuration details for a dedicated server resource.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Hostname of the dedicated server.</item>
/// <item>Number of CPU cores allocated.</item>
/// <item>Amount of memory in gigabytes.</item>
/// <item>Disk size in gigabytes.</item>
/// <item>Physical location of the server.</item>
/// <item>Network speed specification.</item>
/// <item>Tags for categorization or metadata.</item>
/// <item>Additional description or notes.</item>
/// <item>Flag indicating if remote access is enabled.</item>
/// <item>Timestamps for creation and last rental usage.</item>
/// </list>
/// </remarks>
public class DedicatedServerConfigDto
{
    public DedicatedHardwareDto? Hardware { get; set; }
    public LocationDto? Location { get; set; }
    public List<string>? Tags { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? LastRentedAt { get; set; }
}