using System.Text;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PySharp;

/// <summary>
/// Provides methods for output and input operations, similar to Python basic methods.
/// </summary>
public static class Base
{
    /// <summary>
    /// Prints the values to the standard output stream, separated by spaces and ending with a newline.
    /// </summary>
    /// <param name="values">The objects to print. Can be of any type.</param>
    public static void print(params object[] values) => printf(" ", "\n", values);
    /// <summary>
    /// Prints the values to the standard output stream with customizable separator and end characters.
    /// </summary>
    /// <param name="sep">The string inserted between values. Default is a single space.</param>
    /// <param name="end">The string appended after the last value. Default is a newline.</param>
    /// <param name="values">The objects to print. Can be of any type.</param>
    public static void printf(string sep = " ", string end = "\n", params object[] values) => System.Console.Write(string.Join(sep, values) + end);
    /// <summary>
    /// Prints text with a specific foreground color.
    /// </summary>
    /// <param name="color">The color of the text.</param>
    /// <param name="ResetColorOrNot">Use ResetColor() method or not.</param>
    /// <param name="sep">The string inserted between values. Default is a single space.</param>
    /// <param name="end">The string appended after the last value. Default is a newline.</param>
    /// <param name="values">The objects to print.</param>
    public static void printfc(ConsoleColor color, bool ResetColorOrNot, string sep = " ", string end = "\n", params object[] values)
    {
        Console.ForegroundColor = color;
        printf(sep, end, values);
        if (ResetColorOrNot == true)
            Console.ResetColor();
    }
    /// <summary>
    /// Prints text with a specific foreground color.
    /// </summary>
    /// <param name="color">The color of the text.</param>
    /// <param name="ResetColorOrNot">Use ResetColor() method or not.</param>
    /// <param name="sep">The string inserted between values. Default is a single space.</param>
    /// <param name="end">The string appended after the last value. Default is a newline.</param>
    /// <param name="values">The objects to print.</param>
    public static void printbc(ConsoleColor color, bool ResetColorOrNot, string sep = " ", string end = "\n", params object[] values)
    {
        Console.BackgroundColor = color;
        printf(sep, end, values);
        if (ResetColorOrNot == true)
            Console.ResetColor();
    }
    /// <summary>
    /// Plays the sound of a beep through the console speaker.
    /// </summary>
    public static void beep() => Console.Beep();
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
    public static int Int(object? obj)
    {
        if (obj == null) return 0;

        string? d = obj.ToString()?.Trim();
        return Convert.ToInt32(d);
    }
    /// <summary>
    /// Converts a value to a single-precision floating-point number.
    /// </summary>
    /// <param name="obj">The value to convert.</param>
    /// <returns>A floating-point number equivalent to the input.</returns>
    public static float Float(object? obj)
    {
        if (obj == null) return 0.0f;

        string? f = obj.ToString()?.Trim();
        return Convert.ToSingle(f);
    }
    /// <summary>
    /// Converts a value to its string representation.
    /// </summary>
    /// <param name="obj">The value to convert.</param>
    /// <returns>The string representation of the object.</returns>
    public static string str(object? obj) => obj?.ToString() ?? "";
    /// <summary>
    /// Returns the number of items in an object (analogous to Python's len()).
    /// Supports strings, arrays, and collections.
    /// </summary>
    /// <param name="obj">The object to measure.</param>
    /// <returns>The length or count of the object.</returns>
    public static int len(object? obj) => obj switch
    {
        string s => s.Length,
        System.Collections.ICollection c => c.Count,
        _ => 0
    };
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
    /// Converts the first character of the string to uppercase and the rest to lowercase.
    /// </summary>
    /// <param name="text">The string to be capitalized.</param>
    /// <returns>A new string with the first character in uppercase and all others in lowercase.</returns>
    public static string capitalize(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;
        return char.ToUpper(text[0]) + text.Substring(1).ToLower();
    }
    /// <summary>
    /// Returns a titlecased version of the string where words start with an uppercase character.
    /// </summary>
    public static string title(this string text)
    {
        if (string.IsNullOrWhiteSpace(text)) return text;
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
    }
    /// <summary>
    /// Returns a copy of the string with both leading and trailing white-space characters removed.
    /// </summary>
    /// <param name="text">The string to be trimmed.</param>
    /// <returns>The string that remains after all white-space characters are removed from the start and end.</returns>
    public static string strip(this string text) => text.Trim();
    /// <summary>
    /// Returns a copy of the string with uppercase characters converted to lowercase and vice versa.
    /// </summary>
    /// <param name="text">The string to swap cases.</param>
    /// <returns>A new string with inverted case for each character.</returns>
    public static string swapcase(this string text)
    {
        if (string.IsNullOrWhiteSpace(text)) return text;

        StringBuilder s = new(text.Length);

        foreach (char c in text)
        {
            if (char.IsLower(c))
                s.Append(char.ToUpper(c));
            else if (char.IsUpper(c))
                s.Append(char.ToLower(c));
            else
                s.Append(c);
        }
        return s.ToString();
    }
    /// <summary>
    /// Sums the items of an iterable. (Python-style alias for Sum).
    /// </summary>
    /// <param name="nums">An iterable collection of numbers.</param>
    /// <returns>The sum of all numbers in the collection.</returns>
    public static double sum(IEnumerable<double> nums) => nums.Sum();
    /// <summary>
    /// Returns the minimum value in a sequence of double values.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns>The minimum value in the sequence.</returns>
    /// <exception cref="System.ArgumentException"></exception>
    public static double min(params double[] nums)
    {
        if (nums.Length == 0)
            throw new System.ArgumentException("min() arg is an empty sequence");
        return nums.Min();
    }
    /// <summary>
    /// Returns the maximum value in a sequence of double values.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns>The maximum value in the sequence.</returns>
    /// <exception cref="System.ArgumentException"></exception>
    public static double max(params double[] nums)
    {
        if (nums.Length == 0)
            throw new System.ArgumentException("max() arg is an empty sequence");
        return nums.Max();
    }
    /// <summary>
    /// Clears the console buffer and corresponding console window of display information.
    /// </summary>
    public static void clear() => System.Console.Clear();
    /// <summary>
    /// Represents the boolean value True.
    /// </summary>
    public const bool True = true;
    /// <summary>
    /// Represents the boolean value False.
    /// </summary>
    public const bool False = false;
}