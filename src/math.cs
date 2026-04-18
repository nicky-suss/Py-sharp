#pragma warning disable CS8981

namespace PySharp;

/// <summary>
/// Provides methods for math operations, similar to Python's math module.
/// </summary>
public static class math
{
    /// <summary>
    /// Returns the square root of a specified number.
    /// </summary>
    public static double sqrt(double x) => Math.Sqrt(x);
    /// <summary>
    /// Returns a specified number raised to the specified power.
    /// </summary>
    public static double pow(int x, int y) => Math.Pow(x, y);
    /// <summary>
    /// Returns the smallest integral value that is greater than or equal to the specified number.
    /// </summary>
    /// <param name="x">A double-precision floating-point number.</param>
    public static double ceil(double x) => Math.Ceiling(x);
    /// <summary>
    /// Returns the largest integral value that is less than or equal to the specified number.
    /// </summary>
    /// <param name="x">A double-precision floating-point number.</param>
    public static double floor(double x) => Math.Floor(x);
    /// <summary>
    /// Returns the factorial of a number.
    /// </summary>
    public static long factorial(int x)
    {
        long res = 1;
        for (int i = 1; i <= x; i++)
            res *= i;
        return res;
    }
    /// <summary>
    /// Converts angle x from degrees to radians.
    /// </summary>
    public static double radians(double degrees) => degrees * Math.PI / 180;
    /// <summary>
    /// Converts angle x from radians to degrees.
    /// </summary>
    public static double degrees(double radians) => radians * 180 / Math.PI;
    /// <summary>
    /// Returns the sine of the specified angle (in radians).
    /// </summary>
    public static double sin(double x) => Math.Sin(x);
    /// <summary>
    /// Returns the cosine of the specified angle (in radians).
    /// </summary>
    public static double cos(double x) => Math.Cos(x);
    /// <summary>
    /// Returns the tangent of the specified angle (in radians).
    /// </summary>
    public static double tan(double x) => Math.Tan(x);
    /// <summary>
    /// The mathematical constant PI.
    /// </summary>
    public const double pi = Math.PI;
    /// <summary>
    /// The mathematical constant E.
    /// </summary>
    public const double e = Math.E;
}