namespace Contracts.MarketplaceIntegration.DTO.ResourcesConfig;

/// <summary>
/// DTO representing network bandwidth configuration for a virtual machine.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Used in resource creation, update, and response models.</item>
/// <item>Bandwidth is expressed in megabits per second (Mbps).</item>
/// <item>Supports optional burst bandwidth for flexible traffic handling.</item>
/// </list>
/// </remarks>
public class NetworkDto
{
    /// <summary>
    /// Guaranteed network bandwidth in Mbps.
    /// </summary>
    /// <remarks>Always provisioned; defines the baseline throughput.</remarks>
    public uint GuaranteedMbps { get; set; }

    /// <summary>
    /// Optional burstable bandwidth in Mbps.
    /// </summary>
    /// <remarks>May be used during traffic spikes; not always guaranteed.</remarks>
    public uint? BurstMbps { get; set; }
}