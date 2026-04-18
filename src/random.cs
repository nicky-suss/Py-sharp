#pragma warning disable CS8981

namespace PySharp;

/// <summary>
/// Provides methods for random operations, similar to Python random methods.
/// </summary>
public static class random
{
    private static readonly System.Random Rrand = new System.Random();

    /// <summary>
    /// Returns the next random floating point number in the range [0.0, 1.0).
    /// </summary>
    /// <returns>A double-precision floating point number greater than or equal to 0.0, and less than 1.0.</returns>
    public static double Random() => Rrand.NextDouble();
}