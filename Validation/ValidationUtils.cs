namespace Microservices.Contracts.Validation;

/// <summary>
/// Utility methods for common validation logic.
/// </summary>
public static class ValidationUtils
{
    /// <summary>
    /// Checks whether a string is a valid non-empty GUID.
    /// </summary>
    public static bool IsValidGuid(string value)
    {
        return Guid.TryParse(value, out _);
    }
}