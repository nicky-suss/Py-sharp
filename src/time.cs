namespace PySharp;

public class time
{
    /// <summary>
    /// Suspends the current thread for the specified number of seconds.
    /// </summary>
    /// <param name="seconds">The number of seconds to sleep.</param>
    public static void sleep(double seconds) => System.Threading.Thread.Sleep(Convert.ToInt32(seconds * 1000));
}