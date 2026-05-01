#pragma warning disable CS8981

namespace PySharp;

/// <summary>
/// Provides methods for color operations.
/// </summary>
public static class color
{
    /// <summary>
    /// Sets the foreground color of the console.
    /// </summary>
    public static class fore
    {
        /// <summary>
        /// The color black.
        /// </summary>
        public static object? black { get { Console.ForegroundColor = ConsoleColor.Black; return null; } }
        /// <summary>
        /// The color dark blue.
        /// </summary>
        public static object? dark_blue { get { Console.ForegroundColor = ConsoleColor.DarkBlue; return null; } }
        /// <summary>
        /// The color dark green.
        /// </summary>
        public static object? dark_green { get { Console.ForegroundColor = ConsoleColor.DarkGreen; return null; } }
        /// <summary>
        /// The color dark cyan (dark blue-green).
        /// </summary>
        public static object? dark_cyan { get { Console.ForegroundColor = ConsoleColor.DarkCyan; return null; } }
        /// <summary>
        /// The color dark red.
        /// </summary>
        public static object? dark_red { get { Console.ForegroundColor = ConsoleColor.DarkRed; return null; } }
        /// <summary>
        /// The color dark magenta (dark purplish-red).
        /// </summary>
        public static object? dark_magenta { get { Console.ForegroundColor = ConsoleColor.DarkMagenta; return null; } }
        /// <summary>
        /// The color dark yellow (ochre).
        /// </summary>
        public static object? dark_yellow { get { Console.ForegroundColor = ConsoleColor.DarkYellow; return null; } }
        /// <summary>
        /// The color gray.
        /// </summary>
        public static object? gray { get { Console.ForegroundColor = ConsoleColor.Gray; return null; } }
        /// <summary>
        /// The color dark gray.
        /// </summary>
        public static object? dark_gray { get { Console.ForegroundColor = ConsoleColor.DarkGray; return null; } }
        /// <summary>
        /// The color blue.
        /// </summary>
        public static object? blue { get { Console.ForegroundColor = ConsoleColor.Blue; return null; } }
        /// <summary>
        /// The color green.
        /// </summary>
        public static object? green { get { Console.ForegroundColor = ConsoleColor.Green; return null; } }
        /// <summary>
        /// The color cyan (blue-green).
        /// </summary>
        public static object? cyan { get { Console.ForegroundColor = ConsoleColor.Cyan; return null; } }
        /// <summary>
        /// The color red.
        /// </summary>
        public static object? red { get { Console.ForegroundColor = ConsoleColor.Red; return null; } }
        /// <summary>
        /// The color magenta (purplish-red).
        /// </summary>
        public static object? magenta { get { Console.ForegroundColor = ConsoleColor.Magenta; return null; } }
        /// <summary>
        /// The color yellow.
        /// </summary>
        public static object? yellow { get { Console.ForegroundColor = ConsoleColor.Yellow; return null; } }
        /// <summary>
        /// The color White
        /// </summary>
        public static object? white { get { Console.ForegroundColor = ConsoleColor.White; return null; } }
    }
    /// <summary>
    /// Sets the background color of the console
    /// </summary>
    public static class back
    {
        /// <summary>
        /// The color black.
        /// </summary>
        public static object? black { get { Console.BackgroundColor = ConsoleColor.Black; return null; } }
        /// <summary>
        /// The color dark blue.
        /// </summary>
        public static object? dark_blue { get { Console.BackgroundColor = ConsoleColor.DarkBlue; return null; } }
        /// <summary>
        /// The color dark green.
        /// </summary>
        public static object? dark_green { get { Console.BackgroundColor = ConsoleColor.DarkGreen; return null; } }
        /// <summary>
        /// The color dark cyan (dark blue-green).
        /// </summary>
        public static object? dark_cyan { get { Console.BackgroundColor = ConsoleColor.DarkCyan; return null; } }
        /// <summary>
        /// The color dark red
        /// </summary>
        public static object? dark_red { get { Console.BackgroundColor = ConsoleColor.DarkRed; return null; } }
        /// <summary>
        /// The color dark magenta (dark purplish-red).
        /// </summary>
        public static object? dark_magenta { get { Console.BackgroundColor = ConsoleColor.DarkMagenta; return null; } }
        /// <summary>
        /// The color dark yellow (ochre).
        /// </summary>
        public static object? dark_yellow { get { Console.BackgroundColor = ConsoleColor.DarkYellow; return null; } }
        /// <summary>
        /// The color gray.
        /// </summary>
        public static object? gray { get { Console.BackgroundColor = ConsoleColor.Gray; return null; } }
        /// <summary>
        /// The color dark gray.
        /// </summary>
        public static object? dark_gray { get { Console.BackgroundColor = ConsoleColor.DarkGray; return null; } }
        /// <summary>
        /// The color blue.
        /// </summary>
        public static object? blue { get { Console.BackgroundColor = ConsoleColor.Blue; return null; } }
        /// <summary>
        /// The color green
        /// </summary>
        public static object? green { get { Console.BackgroundColor = ConsoleColor.Green; return null; } }
        /// <summary>
        /// The color cyan (blue-green).
        /// </summary>
        public static object? cyan { get { Console.BackgroundColor = ConsoleColor.Cyan; return null; } }
        /// <summary>
        /// The color red.
        /// </summary>
        public static object? red { get { Console.BackgroundColor = ConsoleColor.Red; return null; } }
        /// <summary>
        /// The color magenta (purplish-red).
        /// </summary>
        public static object? magenta { get { Console.BackgroundColor = ConsoleColor.Magenta; return null; } }
        /// <summary>
        /// The color yellow.
        /// </summary>
        public static object? yellow { get { Console.BackgroundColor = ConsoleColor.Yellow; return null; } }
        /// <summary>
        /// The color white.
        /// </summary>
        public static object? white { get { Console.BackgroundColor = ConsoleColor.White; return null; } }
    }
    /// <summary>
    /// Sets the foreground and background console colors to their defaults.
    /// </summary>
    public static void reset() => Console.ResetColor();
    /// <summary>
    /// Sets the title of the console window.
    /// </summary>
    public static void title(string text) => Console.Title = text;
    /// <summary>
    /// Makes the cursor visible or invisible
    /// </summary>
    /// <param name="is_visible"></param>
    public static void cursor_visible(bool is_visible) => Console.CursorVisible = is_visible;
}