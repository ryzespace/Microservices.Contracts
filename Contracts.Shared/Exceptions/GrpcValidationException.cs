using Grpc.Core;
using Contracts.Shared.Grpc.Interceptors;

namespace Contracts.Shared.Exceptions;

/// <summary>
/// Represents a gRPC exception indicating a validation failure.
/// </summary>
/// <remarks>
/// <list type="bullet">
/// <item>Maps to gRPC <see cref="StatusCode.InvalidArgument"/>.</item>
/// <item>Used when input data fails validation rules.</item>
/// <item>Handled by global gRPC exception interceptors.</item>
/// </list>
/// </remarks>
[GrpcStatusCode(StatusCode.InvalidArgument)]
public class GrpcValidationException : Exception
{
    public GrpcValidationException(string message) : base(message) { }

    public GrpcValidationException(string message, Exception innerException)
        : base(message, innerException) { }
}