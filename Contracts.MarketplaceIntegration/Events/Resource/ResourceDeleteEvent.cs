using Contracts.MarketplaceIntegration.Enum;

namespace Contracts.MarketplaceIntegration.Events.Resource;

/// <summary>
/// Represents an event signaling the deletion of a resource.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Contains the identifier of the resource being deleted.</item>
/// <item>Includes the timestamp when the deletion was requested or occurred.</item>
/// </list>
/// </remarks>
public class ResourceDeleteEvent
{
    /// <summary>
    /// Gets or sets the unique identifier of the resource to delete.
    /// </summary>
    public Guid ResourceId { get; set; }

    public ResourceType ResourceType { get; set; }
    
    /// <summary>
    /// Gets or sets the date and time when the deletion occurred or was requested.
    /// </summary>
    public DateTime DeleteAt { get; set; }
}