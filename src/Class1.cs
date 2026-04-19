namespace PySharp;

/// <summary>
/// Provides methods for output and input operations, similar to Python basic methods.
/// </summary>
public static class Base
{
    /// <summary>
    /// Prints an object to the text stream, followed by a line terminator
    /// </summary>
    /// <param name="obj">The object to print</param>
    public static void print(object? obj = null)
    {
        System.Console.WriteLine(obj ?? "");
    }
    /// <summary>
    /// Displays a prompt and reads a line of characters from the standard input stream.
    /// </summary>
    /// <param name="obj">The message to display before reading input.</param>
    /// <returns>The line of characters read from the input.</returns>
    public static string input(string? obj = null)
    {
        if (obj != null)
        {
            System.Console.Write(obj);
        }
        return System.Console.ReadLine() ?? "";
    }
    /// <summary>
    /// Converts a value to an integer.
    /// </summary>
    public static int Int(object obj)
    {
        return (int)Convert.ToInt32(obj);
    }
    /// <summary>
    /// Converts a value to a single-precision floating-point number.
    /// </summary>
    /// <param name="obj">The value to convert.</param>
    /// <returns>A floating-point number equivalent to the input.</returns>
    public static float Float(object obj)
    {
        return Convert.ToSingle(obj);
    }
    /// <summary>
    /// Converts a value to its string representation.
    /// </summary>
    /// <param name="obj">The value to convert.</param>
    /// <returns>The string representation of the object.</returns>
    public static string str(object obj)
    {
        return Convert.ToString(obj);
    }
    /// <summary>
    /// Returns the length (the number of items) of an object.
    /// </summary>
    public static int len(dynamic obj)
    {
        if (obj is System.Array a) return a.Length;
        if (obj is string s) return s.Length;
        return obj.Count;
    }
    /// <summary>
    /// Terminates the current process and returns an exit code to the operating system.
    /// </summary>
    public static void exit() => System.Environment.Exit(0);
    /// <summary>
    /// Converts an integer number to a binary string prefixed with "0b".
    /// </summary>
    /// <param name="tobin">The integer to convert.</param>
    /// <returns>A binary string representation of the number with "0b" prefix.</returns>
    public static string bin(int tobin) => "0b" + System.Convert.ToString(tobin, 2);
    /// <summary>
    /// Converts an integer number to an octal string prefixed with "0o".
    /// </summary>
    /// <param name="tooct">The integer to convert.</param>
    /// <returns>An octal string representation of the number with "0o" prefix.</returns>
    public static string oct(int tooct) => "0o" + System.Convert.ToString(tooct, 8);
    /// <summary>
    /// Converts an integer number to a lowercase hexadecimal string prefixed with "0x".
    /// </summary>
    /// <param name="tohex">The integer to convert.</param>
    /// <returns>A hexadecimal string representation of the number with "0x" prefix.</returns>
    public static string hex(int tohex) => "0x" + System.Convert.ToString(tohex, 16);

    /// <summary>
    /// Returns a copy of this string converted to lowercase.
    /// </summary>
    /// <param name="text"></param>
    /// <returns>A string in lowercase.</returns>
    public static string lower(this string text) => text.ToLower();

    /// <summary>
    /// Returns a copy of this string converted to uppercase.
    /// </summary>
    /// <param name="text"></param>
    /// <returns>The uppercase equivalent of the current string.</returns>
    public static string upper(this string text) => text.ToUpper();

    /// <summary>
    /// Represents the boolean value True.
    /// </summary>
    public const bool True = true;
    /// <summary>
    /// Represents the boolean value False.
    /// </summary>
    public const bool False = false;
}