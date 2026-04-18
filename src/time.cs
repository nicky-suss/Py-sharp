#pragma warning disable CS8981

namespace PySharp;

/// <summary>
/// Provides methods for time-related operations, similar to Python's time module.
/// </summary>
public static class time
{
    /// <summary>
    /// Suspends the current thread for the specified number of seconds.
    /// </summary>
    /// <param name="seconds">The number of seconds to sleep.</param>
    public static void sleep(double seconds) => System.Threading.Thread.Sleep(Convert.ToInt32(seconds * 1000));
    /// <summary>
    /// Returns the current time in seconds since the Epoch (January 1, 1970, 00:00:00 UTC).
    /// </summary>
    /// <returns>Current time in seconds.</returns>
    public static double Time() => System.DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    /// <summary>
    /// Converts a time expressed in seconds since the epoch to a string representing local time.
    /// </summary>
    /// <returns>A string representation of the current local time.</returns>
    public static string ctime() => DateTime.Now.ToString("ddd MMM dd HH:mm:ss yyyy");
}