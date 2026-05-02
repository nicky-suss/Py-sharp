#pragma warning disable CS8981

using System.Text;
using System;
using System.Linq;
using System.Collections.Generic;

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
    /// Returns the cube root of x.
    /// </summary>
    public static double cbrt(double x) => Math.Cbrt(x);
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
    /// Returns the arc cosine of x, in radians.
    /// </summary>
    public static double acos(double x) => Math.Acos(x);
    /// <summary>
    /// Returns the inverse hyperbolic cosine of x.
    /// </summary>
    public static double acosh(double x) => Math.Acosh(x);
    /// <summary>
    /// Returns the arc sine of x, in radians.
    /// </summary>
    public static double asin(double x) => Math.Asin(x);
    /// <summary>
    /// Returns the inverse hyperbolic sine of x.
    /// </summary>
    public static double asinh(double x) => Math.Asinh(x);
    /// <summary>
    /// Returns the arc tangent of x, in radians.
    /// </summary>
    public static double atan(double x) => Math.Atan(x);
    /// <summary>
    /// Returns the arc tangent of y/x, in radians.
    /// </summary>
    public static double atan2(double y, double x) => Math.Atan2(y, x);
    /// <summary>
    /// Returns the inverse hyperbolic tangent of x.
    /// </summary>
    public static double atanh(double x) => Math.Atanh(x);
    /// <summary>
    /// Returns a value indicating whether the specified number evaluates to negative or positive infinity.
    /// </summary>
    /// <returns>true if d evaluates to double.PositiveInfinity or double.NegativeInfinity; otherwise, false.</returns>
    public static bool isinf(double x) => double.IsInfinity(x);
    /// <summary>
    /// Returns a value that indicates whether the specified value is not a number (double.NaN).
    /// </summary>
    /// <returns>true if d evaluates to double.NaN; otherwise, false.</returns>
    public static bool isnan(double x) => double.IsNaN(x);
    /// <summary>
    /// The mathematical constant PI.
    /// </summary>
    public static readonly double pi = Math.PI;
    /// <summary>
    /// The mathematical constant E.
    /// </summary>
    public static readonly double e = Math.E;
    /// <summary>
    /// Represents a value that is not a number (NaN). This field is constant.
    /// </summary>
    public static readonly double nan = double.NaN;
    /// <summary>
    /// Represents positive infinity. This field is constant.
    /// </summary>
    public static readonly double inf = double.PositiveInfinity;
    /// <summary>
    /// Represents the number of radians in one turn, specified by the constant, τ.
    /// </summary>
    public static readonly double tau = Math.Tau;
}