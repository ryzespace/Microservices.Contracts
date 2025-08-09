namespace Contracts.MarketplaceIntegration.DTO.ResourcesConfig;

/// <summary>
/// DTO representing virtual machine hardware configuration.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Used for resource creation or update operations.</item>
/// <item>Fields are required with default values; partial updates should be handled explicitly.</item>
/// <item>Values represent hardware characteristics in standard units (e.g., GB, cores).</item>
/// </list>
/// </remarks>
public class VmHardwareDto
{
    /// <summary>
    /// Number of CPU cores
    /// </summary>
    /// <remarks>Fractional values (e.g., 0.5) are allowed for shared environments.</remarks>
    public double CpuCores { get; set; }

    /// <summary>
    /// Amount of memory in gigabytes
    /// </summary>
    /// <remarks>Must be a positive value if specified.</remarks>
    public double MemoryGb { get; set; }
    
    /// <summary>
    /// Disk size in gigabytes
    /// </summary>
    /// <remarks>Used to define persistent storage capacity.</remarks>
    public double DiskSizeGb { get; set; }
    
    /// <summary>
    /// CPU model name or identifier
    /// </summary>
    /// <remarks>Can be used for filtering or informational display.</remarks>
    public string CpuModel { get; set; }
    
    /// <summary>
    /// GPU model name or identifier (optional).
    /// </summary>
    /// <remarks>Set if a GPU is available or relevant for the VM workload.</remarks>
    public string? GpuModel { get; set; }
}