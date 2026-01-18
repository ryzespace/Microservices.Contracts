<div align="center">

# RyzeSpace.Contracts

### The foundation of decentralized computational resource sharing

[![NuGet](https://img.shields.io/nuget/v/RyzeSpace.Contracts?style=flat-square&logo=nuget&color=004880)](https://nuget.org)
[![License](https://img.shields.io/badge/license-MIT%20%2B%20Commons%20Clause-7c3aed?style=flat-square)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com)
</div>

---

## Overview

RyzeSpace.Contracts serve as the **single source of truth** for all service-to-service communication in the RyzeSpace ecosystem. This centralized contract repository ensures type-safe, versioned, and consistent data exchange across our distributed microservices architecture.

```bash
dotnet add package RyzeSpace.Contracts
```

## Why Contracts Matter

In a microservices ecosystem, contracts are the glue that holds everything together. They provide:

- **Type Safety** — Compile-time validation of inter-service communication
- **Version Control** — Clear evolution path for API changes
- **Documentation** — Self-documenting service interfaces
- **Consistency** — Unified data structures across the platform

## Architecture

```
RyzeSpace.Contracts/
│
├── Integration Events/          # Cross-service event contracts
│   └── MarketplaceIntegration/  # Marketplace domain events
│
└── Shared/                      # Common contracts
    ├── Exceptions/              # Platform-wide exception types
    ├── Grpc/                    # gRPC service definitions
    └── Validation/              # Validation rules & attributes
```

## Contract Categories

### Integration Events

Event-driven communication contracts for asynchronous service integration.

```csharp
// Example: Resource lifecycle evets
namespace Contracts.MarketplaceIntegration.Events.Resource;

public class RentalCreatedEvent
{
    public Guid SellerId { get; set; }
    public Guid ResourceId { get; set; }
    public ResourceConfigurationDto Configuration { get; set; }
    public DateTime CreatedAt { get; set; }
}
```

### Shared Contracts

Reusable components for common functionality across services.

| Category | Purpose | Use Cases |
|----------|---------|-----------|
| **Exceptions** | Standardized error handling | Domain errors, validation failures, infrastructure issues |
| **gRPC** | High-performance RPC | Real-time resource allocation, health checks |
| **Validation** | Business rule enforcement | Input validation, constraint checking |

## Installation

### Package Manager Console
```powershell
Install-Package RyzeSpace.Contracts
```

### .NET CLI
```bash
dotnet add package RyzeSpace.Contracts
```

### PackageReference
```xml
<PackageReference Include="RyzeSpace.Contracts" Version="1.0.0" />
```

## Contributing

We welcome contributions that improve contract clarity, expand integration patterns, or enhance type safety.

### Development Guidelines

1. **Branch Strategy** — Create feature branches from `main`
   ```bash
   git checkout -b feature/payment-events
   ```

2. **Naming Conventions**
    - Events: `{Entity}{Action}Event` (e.g., `ResourceCreatedEvent`)
    - DTOs: `{Purpose}Dto` (e.g., `ResourceAllocationDto`)
    - Namespaces: Follow domain structure

3. **Versioning** — Use semantic versioning (MAJOR.MINOR.PATCH)
    - MAJOR: Breaking changes
    - MINOR: New contracts (backward compatible)
    - PATCH: Bug fixes, documentation

4. **Pull Request** — Provide clear descriptions of changes and impact

## License

**MIT License + Commons Clause**

The RyzeSpace.Contracts library is open source for personal, educational, and research purposes. Commercial use requires explicit permission.

### Permitted Use ✓

- Personal projects and learning
- Academic research and education
- Open source contributions
- Non-commercial experimentation

### Restricted Use ✗

- Commercial products and services
- SaaS platform offerings
- Software resale or licensing
- Consulting services without approval

See [LICENSE](LICENSE) for complete terms.

---

<div align="center">

### Part of the RyzeSpace Ecosystem

**Democratizing access to computational resources through decentralized sharing**

*Every idle GPU, every spare CPU cycle — unlocking potential in the RyzeSpace network*

<br/>

**[Documentation](https://docs.ryzespace.com)** • **[Platform](https://ryzespace.com)** • **[Community](https://discord.gg/JsQx8cQ5yp)**

<br/>

<sub>Built with precision by the RyzeSpace team</sub>

</div>