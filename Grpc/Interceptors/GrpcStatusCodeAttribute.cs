using Grpc.Core;

namespace Microservices.Contracts.Grpc.Interceptors;

/// <summary>
/// An attribute used to associate a gRPC status code with a specific exception class.
/// </summary>
/// <remarks>
/// This attribute can be applied to exception classes to define the gRPC
/// that will be returned when the exception is handled by a corresponding gRPC interceptor.
/// It provides a mechanism to map application-specific exceptions to gRPC status codes, enabling
/// more descriptive and appropriate error responses in gRPC communications.
/// </remarks>
/// <param name="statusCode">The gRPC status code to be associated with the exception.</param>
[AttributeUsage(AttributeTargets.Class)]
public class GrpcStatusCodeAttribute(StatusCode statusCode) : Attribute
{
    public StatusCode StatusCode { get; } = statusCode;
}
