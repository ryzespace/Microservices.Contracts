using System.Globalization;

namespace Contracts.Shared.Validation;

/// <summary>
/// Utility methods for validating availability slot data.
/// </summary>
public static class AvailabilityValidationUtils
{
    private static readonly string[] AllowedDays =
    [
        "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
    ];

    public static bool IsValidDayOfWeek(string day)
    {
        return !string.IsNullOrWhiteSpace(day)
               && Array.Exists(AllowedDays, d => string.Equals(d, day, StringComparison.OrdinalIgnoreCase));
    }

    public static bool IsValidTime(string time)
    {
        return !string.IsNullOrWhiteSpace(time)
               && (TimeSpan.TryParseExact(time, "hh\\:mm", CultureInfo.InvariantCulture, out _)
                   || TimeSpan.TryParseExact(time, "HH\\:mm", CultureInfo.InvariantCulture, out _));
    }

    public static bool IsEndTimeAfterStartTime(string startTime, string endTime)
    {
        if (!IsValidTime(startTime) || !IsValidTime(endTime))
            return true; // skip comparison if time parsing fails

        var start = TimeSpan.ParseExact(startTime, "hh\\:mm", CultureInfo.InvariantCulture);
        var end = TimeSpan.ParseExact(endTime, "hh\\:mm", CultureInfo.InvariantCulture);
        return end > start;
    }
}