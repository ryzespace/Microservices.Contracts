namespace Contracts.MarketplaceIntegration.Enum;

/// <summary>
/// Represents the type of resource in the system and defines its category for 
/// handling, persistence, and lifecycle operations.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Used by repositories and services to distinguish between VM and dedicated server resources.</item>
/// <item>Impacts domain events, operations, and validation rules.</item>
/// </list>
/// </remarks>
public enum ResourceType
{
    Vm,
    DedicatedServer
}