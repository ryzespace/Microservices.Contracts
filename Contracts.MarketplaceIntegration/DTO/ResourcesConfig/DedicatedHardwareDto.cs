namespace Contracts.MarketplaceIntegration.DTO.ResourcesConfig;

/// <summary>
/// Data Transfer Object representing dedicated hardware specifications of a resource.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>All properties are optional to support partial updates or incomplete data.</item>
/// <item>Includes core hardware attributes like CPU, memory, disk, network, and GPU info.</item>
/// </list>
/// </remarks>
public class DedicatedHardwareDto
{
    /// <summary>
    /// Hostname of the hardware (optional).
    /// </summary>
    public string? Hostname { get; set; }

    /// <summary>
    /// Number of CPU cores (optional).
    /// </summary>
    public double? CpuCores { get; set; }

    /// <summary>
    /// Amount of memory in gigabytes (optional).
    /// </summary>
    public double? MemoryGb { get; set; }

    /// <summary>
    /// Disk size in gigabytes (optional).
    /// </summary>
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// Network speed description, e.g., "1 Gbps" (optional).
    /// </summary>
    public string? NetworkSpeed { get; set; }

    /// <summary>
    /// CPU model name or identifier (optional).
    /// </summary>
    public string? CpuModel { get; set; }

    /// <summary>
    /// RAM type, e.g., DDR4 (optional).
    /// </summary>
    public string? RamType { get; set; }

    /// <summary>
    /// Disk type, e.g., SSD, HDD (optional).
    /// </summary>
    public string? DiskType { get; set; }

    /// <summary>
    /// RAID level for disks, e.g., RAID0, RAID1 (optional).
    /// </summary>
    public string? DiskRaidLevel { get; set; }

    /// <summary>
    /// Number of physical disks (optional).
    /// </summary>
    public int? DiskCount { get; set; }

    /// <summary>
    /// GPU model name or identifier (optional).
    /// </summary>
    public string? GpuModel { get; set; }
}