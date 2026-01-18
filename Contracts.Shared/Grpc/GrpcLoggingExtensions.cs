using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Contracts.Shared.Grpc;

/// <summary>
/// Provides extension methods for logging gRPC requests in a structured JSON format.
/// </summary>
/// <remarks>
/// Designed to assist debugging and monitoring of gRPC calls by serializing requests
/// and logging them at the specified <see cref="LogLevel"/>.
/// </remarks>
public static class GrpcLoggingExtensions
{
    /// <summary>
    /// Logs a gRPC request in formatted JSON with a method header.
    /// </summary>
    /// <typeparam name="T">Type of the gRPC request.</typeparam>
    /// <param name="logger">The <see cref="ILogger"/> instance.</param>
    /// <param name="methodName">The name of the gRPC method being logged.</param>
    /// <param name="request">The gRPC request object to log.</param>
    /// <param name="level">The log level to use (default: <see cref="LogLevel.Debug"/>).</param>
    public static void LogGrpcRequest<T>(
        this ILogger logger,
        string methodName,
        T request,
        LogLevel level = LogLevel.Debug)
    {
        var json = JsonConvert.SerializeObject(request, Formatting.Indented);
        var message = $"\n=== gRPC {methodName} request ===\n{json}\n=== END ===";

        switch (level)
        {
            case LogLevel.Trace: logger.LogTrace(message); break;
            case LogLevel.Debug: logger.LogDebug(message); break;
            case LogLevel.Information: logger.LogInformation(message); break;
            case LogLevel.Warning: logger.LogWarning(message); break;
            case LogLevel.Error: logger.LogError(message); break;
            case LogLevel.Critical: logger.LogCritical(message); break;
            default: logger.LogDebug(message); break;
        }
    }
}