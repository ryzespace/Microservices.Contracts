using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Contracts.Shared.Extensions;

/// <summary>
/// Provides extension methods for logging domain-level operations.
/// </summary>
/// <remarks>
/// Enables structured, transport-agnostic logging of operation completions,
/// optionally including serialized result payloads.
/// </remarks>
public static class OperationLoggingExtensions
{
    /// <param name="logger">The <see cref="ILogger"/> instance.</param>
    extension(ILogger logger)
    {
        /// <summary>
        /// Logs successful completion of an operation correlated by RequestId.
        /// </summary>
        /// <param name="operation">The name of the operation.</param>
        /// <param name="requestId">The correlation identifier for the operation.</param>
        public void LogOperationCompleted(string operation,
            string requestId)
        {
            logger.LogInformation(
                "{Operation} completed for RequestId: {RequestId}",
                operation,
                requestId
            );
        }

        /// <summary>
        /// Logs successful completion of an operation with a result payload.
        /// The payload is serialized as indented JSON for readability.
        /// </summary>
        /// <typeparam name="T">Type of the result object.</typeparam>
        /// <param name="operation">The name of the operation.</param>
        /// <param name="result">The operation result to log.</param>
        public void LogOperationCompleted<T>(string operation,
            T result)
            where T : notnull
        {
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            logger.LogInformation(
                "\n=== {Operation} completed ===\n{JsonResult}\n=== END ===",
                operation,
                json
            );
        }
    }
}