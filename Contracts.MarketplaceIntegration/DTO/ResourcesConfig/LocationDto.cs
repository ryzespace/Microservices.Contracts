namespace Contracts.MarketplaceIntegration.DTO.ResourcesConfig;

/// <summary>
/// Data Transfer Object representing a geographical location for a resource.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Contains optional country, city, and data center/cluster name.</item>
/// <item>Used for transferring location data across application boundaries.</item>
/// </list>
/// </remarks>
public class LocationDto
{
    /// <summary>
    /// Country name (optional).
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// City name (optional).
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Data center or cluster name (optional).
    /// </summary>
    public string? DataCenterName { get; set; }
}