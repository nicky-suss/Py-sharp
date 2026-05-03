#pragma warning disable CS8981

using System.Text;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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
    /// <summary>
    /// Returns a random integer N such that a &lt;= N &lt;= b.
    /// </summary>
    /// <param name="a">The lower bound (inclusive).</param>
    /// <param name="b">The upper bound (inclusive).</param>
    /// <returns>A random integer within the specified range.</returns>
    public static int randint(int a, int b) => Rrand.Next(a, b + 1);
    /// <summary>
    /// Returns a random floating point number N such that a &lt;= N &lt;= b.
    /// </summary>
    /// <param name="a">The lower bound.</param>
    /// <param name="b">The upper bound.</param>
    /// <returns>A random double-precision floating point number.</returns>
    public static double uniform(double a, double b) => a + (Rrand.NextDouble() * (b - a));
    /// <summary>
    /// 
    /// </summary>
    public static string? choice(object? obj)
    {
        if (obj is System.Collections.IList l && l.Count > 0)
        {
            object? randomList = l[Rrand.Next(l.Count)];
            return randomList?.ToString();
        }
        return null;
    }
    /// <summary>
    /// 
    /// </summary>
    public static void shuffle<T>(this List<T> list)
    {
        Span<T> span = CollectionsMarshal.AsSpan(list);
        System.Random.Shared.Shuffle(span);
    }
    /// <summary>
    /// 
    /// </summary>
    public static void shuffle<T>(this T[] array)
    {
        System.Random.Shared.Shuffle(array);
    }
    /// <summary>
    /// 
    /// </summary>
    public static string sample<T>(this T[] array, int k)
    {
        System.Random.Shared.Shuffle(array);
        return string.Join(", ", array[..k]);
    }
    /// <summary>
    /// 
    /// </summary>
    public static string choices<T>(this T[] array, int k)
    {
        T[] result = System.Random.Shared.GetItems(array, k);
        return string.Join(", ", result);
    }
}