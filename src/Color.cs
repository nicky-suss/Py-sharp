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
        public static void black() => Console.ForegroundColor = ConsoleColor.Black;
        /// <summary>
        /// The color dark blue.
        /// </summary>
        public static void dark_blue() => Console.ForegroundColor = ConsoleColor.DarkBlue;
        /// <summary>
        /// The color dark green.
        /// </summary>
        public static void dark_green() => Console.ForegroundColor = ConsoleColor.DarkGreen;
        /// <summary>
        /// The color dark cyan (dark blue-green).
        /// </summary>
        public static void dark_cyan() => Console.ForegroundColor = ConsoleColor.DarkCyan;
        /// <summary>
        /// The color dark red.
        /// </summary>
        public static void dark_red() => Console.ForegroundColor = ConsoleColor.DarkRed;
        /// <summary>
        /// The color dark magenta (dark purplish-red).
        /// </summary>
        public static void dark_magenta() => Console.ForegroundColor = ConsoleColor.DarkMagenta;
        /// <summary>
        /// The color dark yellow (ochre).
        /// </summary>
        public static void dark_yellow() => Console.ForegroundColor = ConsoleColor.DarkYellow;
        /// <summary>
        /// The color gray.
        /// </summary>
        public static void gray() => Console.ForegroundColor = ConsoleColor.Gray;
        /// <summary>
        /// The color dark gray.
        /// </summary>
        public static void dark_gray() => Console.ForegroundColor = ConsoleColor.DarkGray;
        /// <summary>
        /// The color blue.
        /// </summary>
        public static void blue() => Console.ForegroundColor = ConsoleColor.Blue;
        /// <summary>
        /// The color green.
        /// </summary>
        public static void green() => Console.ForegroundColor = ConsoleColor.Green;
        /// <summary>
        /// The color cyan (blue-green).
        /// </summary>
        public static void cyan() => Console.ForegroundColor = ConsoleColor.Cyan;
        /// <summary>
        /// The color red.
        /// </summary>
        public static void red() => Console.ForegroundColor = ConsoleColor.Red;
        /// <summary>
        /// The color magenta (purplish-red).
        /// </summary>
        public static void magenta() => Console.ForegroundColor = ConsoleColor.Magenta;
        /// <summary>
        /// The color yellow.
        /// </summary>
        public static void yellow() => Console.ForegroundColor = ConsoleColor.Yellow;
        /// <summary>
        /// The color White
        /// </summary>
        public static void white() => Console.ForegroundColor = ConsoleColor.White;
    }
    /// <summary>
    /// Sets the background color of the console
    /// </summary>
    public static class back
    {
        /// <summary>
        /// The color black.
        /// </summary>
        public static void black() => Console.BackgroundColor = ConsoleColor.Black;
        /// <summary>
        /// The color dark blue.
        /// </summary>
        public static void dark_blue() => Console.BackgroundColor = ConsoleColor.DarkBlue;
        /// <summary>
        /// The color dark green.
        /// </summary>
        public static void dark_green() => Console.BackgroundColor = ConsoleColor.DarkGreen;
        /// <summary>
        /// The color dark cyan (dark blue-green).
        /// </summary>
        public static void dark_cyan() => Console.BackgroundColor = ConsoleColor.DarkCyan;
        /// <summary>
        /// The color dark red
        /// </summary>
        public static void dark_red() => Console.BackgroundColor = ConsoleColor.DarkRed;
        /// <summary>
        /// The color dark magenta (dark purplish-red).
        /// </summary>
        public static void dark_magenta() => Console.BackgroundColor = ConsoleColor.DarkMagenta;
        /// <summary>
        /// The color dark yellow (ochre).
        /// </summary>
        public static void dark_yellow() => Console.BackgroundColor = ConsoleColor.DarkYellow;
        /// <summary>
        /// The color gray.
        /// </summary>
        public static void gray() => Console.BackgroundColor = ConsoleColor.Gray;
        /// <summary>
        /// The color dark gray.
        /// </summary>
        public static void dark_gray() => Console.BackgroundColor = ConsoleColor.DarkGray;
        /// <summary>
        /// The color blue.
        /// </summary>
        public static void blue() => Console.BackgroundColor = ConsoleColor.Blue;
        /// <summary>
        /// The color green
        /// </summary>
        public static void green() => Console.BackgroundColor = ConsoleColor.Green;
        /// <summary>
        /// The color cyan (blue-green).
        /// </summary>
        public static void cyan() => Console.BackgroundColor = ConsoleColor.Cyan;
        /// <summary>
        /// The color red.
        /// </summary>
        public static void red() => Console.BackgroundColor = ConsoleColor.Red;
        /// <summary>
        /// The color magenta (purplish-red).
        /// </summary>
        public static void magenta() => Console.BackgroundColor = ConsoleColor.Magenta;
        /// <summary>
        /// The color yellow.
        /// </summary>
        public static void yellow() => Console.BackgroundColor = ConsoleColor.Yellow;
        /// <summary>
        /// The color white.
        /// </summary>
        public static void white() => Console.BackgroundColor = ConsoleColor.White;
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