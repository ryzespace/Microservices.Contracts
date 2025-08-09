namespace Contracts.MarketplaceIntegration.DTO.ResourcesConfig;

/// <summary>
/// Configuration details for a virtual machine resource.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Description of the VM.</item>
/// <item>Number of CPU cores allocated.</item>
/// <item>Amount of memory in gigabytes.</item>
/// <item>Disk size in gigabytes.</item>
/// <item>Operating system image identifier.</item>
/// <item>Flag indicating if SSH access is enabled.</item>
/// <item>Description providing additional information.</item>
/// <item>Timestamps for creation and last rental usage.</item>
/// </list>
/// </remarks>
public class VmConfigDto
{
    /// <summary>
    /// Optional description providing additional information about the VM.
    /// </summary>
    public string? Description { get; set; }
        
    /// <summary>
    /// Operating system image name or identifier.
    /// </summary>
    /// <remarks>Specifies the OS image used by the VM.</remarks>
    public string? OsImage { get; set; }
        
    /// <summary>
    /// Hardware configuration details of the VM.
    /// </summary>
    public VmHardwareDto? Hardware { get; set; }
        
    /// <summary>
    /// Network bandwidth configuration of the VM.
    /// </summary>
    public NetworkDto? Network { get; set; }
        
    /// <summary>
    /// Location details where the VM is hosted.
    /// </summary>
    public LocationDto? Location { get; set; }
        
    /// <summary>
    /// Timestamp when the VM was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }
        
    /// <summary>
    /// Timestamp of the last time the VM was rented.
    /// </summary>
    public DateTime LastRentedAt { get; set; }
}