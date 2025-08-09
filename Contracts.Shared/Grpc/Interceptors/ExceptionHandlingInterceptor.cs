using System.Reflection;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Microsoft.Extensions.Logging;

namespace Contracts.Shared.Grpc.Interceptors;
 
/// <summary>
/// Interceptor responsible for handling exceptions during gRPC calls and converting
/// them into appropriate gRPC responses.
/// </summary>
/// <remarks>
/// This class ensures that any unhandled exceptions occurring during the execution
/// of a unary gRPC call are logged and translated into an appropriate `RpcException`
/// to be sent to the caller. It provides a consistent mechanism for error handling
/// across all gRPC calls in the application.
/// </remarks>
/// <param name="logger">Logger instance used for error logging.</param>
public class ExceptionHandlingInterceptor(ILogger<ExceptionHandlingInterceptor> logger) : Interceptor
{
    private const string ErrorMessageTemplate = """
        Error while processing a gRPC request
        ======================================
        Method:     {Method}
        Type of error:  {ExceptionType}
        Details:
        {Error}
        """;

    private const string DefaultErrorMessage = "An unexpected error occurred while processing the request.";

    /// <inheritdoc />
    public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
        TRequest request,
        ServerCallContext context,
        UnaryServerMethod<TRequest, TResponse> continuation)
    {
        try
        {
            return await continuation(request, context);
        }
        catch (Exception exception)
        {
            LogException(context, exception);
            throw CreateRpcException(exception);
        }
    }

    private void LogException(ServerCallContext context, Exception exception)
    {
        var formattedError = FormatExceptionDetails(exception);
        logger.LogError(ErrorMessageTemplate,
            context.Method,
            exception.GetType().Name,
            formattedError);
    }

    private static RpcException CreateRpcException(Exception exception)
    {
        var errorStatus = CreateErrorStatus(exception);
        return new RpcException(errorStatus);
    }

    private static Status CreateErrorStatus(Exception exception)
    {
        if (exception is FluentValidation.ValidationException validationException)
        {
            var details = string.Join("\n", validationException.Errors.Select(e => $"- {e.ErrorMessage}"));
            return new Status(StatusCode.InvalidArgument, $"Validation failed:\n{details}");
        }

        var statusCodeAttribute = exception.GetType().GetCustomAttribute<GrpcStatusCodeAttribute>();
        var errorMessage = statusCodeAttribute is not null 
            ? FormatExceptionDetails(exception)
            : DefaultErrorMessage;

        return new Status(
            statusCodeAttribute?.StatusCode ?? StatusCode.Internal,
            errorMessage);
    }

    private static string FormatExceptionDetails(Exception exception)
    {
        #if DEBUG
        return $"""
                {exception.Message}

                Stack Trace:
                {exception.StackTrace}
                """;
        #else
            return $"""
                {exception.Message}
                """;
        #endif
    }
}