namespace Contracts.MarketplaceIntegration.DTO.ResourcesConfig;
/// <summary>
/// Represents configuration settings for a resource.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Holds optional virtual machine configuration.</item>
/// <item>Holds optional dedicated server configuration.</item>
/// </list>
/// </remarks>
public class ResourceConfigurationDto
{
    /// <summary>
    /// Virtual machine configuration settings, if applicable.
    /// </summary>
    public VmConfigDto? VmConfig { get; set; }

    /// <summary>
    /// Dedicated server configuration settings, if applicable.
    /// </summary>
    public DedicatedServerConfigDto? DedicatedServerConfig { get; set; }
}