using Contracts.MarketplaceIntegration.DTO.ResourcesConfig;

namespace Contracts.MarketplaceIntegration.Events.Resource;

/// <summary>
/// Event emitted when a seller creates a new rental.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Contains the identifier of the seller who created the rental.</item>
/// <item>Includes the configuration details of the rented resource.</item>
/// <item>Records the creation timestamp of the rental event.</item>
/// </list>
/// </remarks>
public class RentalCreatedEvent
{
    /// <summary>
    /// Gets or sets the unique identifier of the seller.
    /// </summary>
    public Guid SellerId { get; set; }
    
    /// <summary>
    /// Gets or sets the unique identifier of the resource.
    /// </summary>
    public Guid ResourceId { get; set; }
    
    /// <summary>
    /// Gets or sets the resource configuration details associated with the rental.
    /// </summary>
    public ResourceConfigurationDto Configuration { get; set; } = null!;

    /// <summary>
    /// Gets or sets the UTC timestamp when the rental was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }
}