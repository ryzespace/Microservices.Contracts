using Contracts.MarketplaceIntegration.DTO.ResourcesConfig;

namespace Contracts.MarketplaceIntegration.Events;

/// <summary>
/// Event representing an update to an existing resource's configuration.
/// </summary>
/// <remarks>
/// This event is emitted when a VM or dedicated server resource has been updated,
/// including its technical configuration and metadata.
/// <list type="bullet">
/// <item><description>Used in event-driven pipelines to reflect configuration changes.</description></item>
/// <item><description>Consumed by downstream services (e.g., runtime, marketplace sync).</description></item>
/// </list>
/// </remarks>
public class ResourceUpdatedEvent
{
    /// <summary>
    /// Unique identifier of the updated resource.
    /// </summary>
    public Guid ResourceId { get; set; }

    /// <summary>
    /// Timestamp of when the resource was updated.
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// Updated configuration details of the resource.
    /// </summary>
    public ResourceConfigurationDto Configuration { get; set; } = null!;
}