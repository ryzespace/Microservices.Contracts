<div align="center">

# Rentix.Contracts

![Rentix Logo](https://img.shields.io/badge/Rentix-Contracts-blue?style=for-the-badge)
[![NuGet](https://img.shields.io/badge/NuGet-Package-green?style=for-the-badge)](https://nuget.org)
[![License](https://img.shields.io/badge/License-MIT%20%2B%20Commons%20Clause-red?style=for-the-badge)](LICENSE)

**Centralized repository of shared contracts for Rentix microservices ecosystem**

*The single source of truth for DTOs, events, and integration contracts powering the computational resource sharing platform.*
</div>

---

## 📦 Purpose

This repository contains **shared contracts** that define the communication boundaries between Rentix microservices.  
It ensures **consistency**, **type-safety**, and **version control** for cross-service data exchange.

### 🔑 Key Responsibilities

- Hosting **integration event contracts** (e.g., `resource.created`, `rental.updated`)
- Defining **shared DTOs** for inter-service requests and responses
- Maintaining **clear namespaces** for service-to-service communication
- Providing a **NuGet package** for easy consumption by all services

---

## 🤝 Contributing

### Development Workflow

1. **Fork** the repository
2. **Create** feature branch (`git checkout -b feature/new-contract`)
3. **Add** your contracts following naming conventions
4. **Test** contract serialization/deserialization
5. **Update** version in `.csproj` following semantic versioning
6. **Submit** pull request with detailed description

## 🚀 Getting Started

### Installation

```bash
# Install via NuGet Package Manager
Install-Package Rentix.Contracts

# Or via .NET CLI
dotnet add package Rentix.Contracts
```


## 📋 Contract Catalog

### 🔄 Integration Events

| Namespace                                 | Purpose                          | Key Events |
| ----------------------------------------- | -------------------------------- | ---------- |
| `Contracts.MarketplaceIntegration.Events` | Cross-service integration events | `Soon`     |

### 📊 Shared Contracts

| Namespace | Purpose | Components |
|-----------|---------|------------|
| `Contracts.Shared.Exceptions` | Shared exception contracts | Custom exceptions across services |
| `Contracts.Shared.Grpc` | gRPC service contracts | High-performance inter-service communication |
| `Contracts.Shared.Interfaces` | Common interface definitions | Service contracts and abstractions |
| `Contracts.Shared.Validation` | Validation contracts | Shared validation logic and rules |

---

## 🔐 License and Usage

### MIT License + Commons Clause

```
MIT License with Commons Clause

Copyright (c) 2025 Rentix Platform Contributors

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The Software shall be used for Good, not Evil.

⚠️  COMMERCIAL USE RESTRICTION:
The Software may not be used for commercial purposes without explicit 
written permission from the copyright holders.
```

### 💡What Does This Mean?

| Allowed ✅                 | Prohibited ❌          |
|---------------------------|-----------------------|
| Personal use              | Commercial products   |
| Educational projects      | SaaS offerings        |
| Scientific research       | Software resale       |
| Open source contributions | White-label solutions |
| Learning and experiments  | Consulting services   |

---

<div align="center">

## 🌟 The Rentix Platform

**Democratizing computational resources through decentralized sharing**

*From your spare laptop to enterprise-grade servers - every resource has value in the Rentix ecosystem.*

---

**🚀 Building the future of computational resource sharing, one contract at a time!**

📦 *Clean contracts are the foundation of scalable microservices architecture.*

*Made with ❤️ by the Rentix Team*

---

[⬆️ Back to Top](#rentixcontracts)

</div>