namespace PySharp;

/// <summary>
/// Provides methods for color operations.
/// </summary>
public static class Color
{
    /// <summary>
    /// Sets the foreground color of the console.
    /// </summary>
    public static class Fore
    {
        /// <summary>
        /// The color black.
        /// </summary>
        public static void Black() => Console.ForegroundColor = ConsoleColor.Black;
        /// <summary>
        /// The color dark blue.
        /// </summary>
        public static void DarkBlue() => Console.ForegroundColor = ConsoleColor.DarkBlue;
        /// <summary>
        /// The color dark green.
        /// </summary>
        public static void DarkGreen() => Console.ForegroundColor = ConsoleColor.DarkGreen;
        /// <summary>
        /// The color dark cyan (dark blue-green).
        /// </summary>
        public static void DarkCyan() => Console.ForegroundColor = ConsoleColor.DarkCyan;
        /// <summary>
        /// The color dark red.
        /// </summary>
        public static void DarkRed() => Console.ForegroundColor = ConsoleColor.DarkRed;
        /// <summary>
        /// The color dark magenta (dark purplish-red).
        /// </summary>
        public static void DarkMagenta() => Console.ForegroundColor = ConsoleColor.DarkMagenta;
        /// <summary>
        /// The color dark yellow (ochre).
        /// </summary>
        public static void DarkYellow() => Console.ForegroundColor = ConsoleColor.DarkYellow;
        /// <summary>
        /// The color gray.
        /// </summary>
        public static void Gray() => Console.ForegroundColor = ConsoleColor.Gray;
        /// <summary>
        /// The color dark gray.
        /// </summary>
        public static void DarkGray() => Console.ForegroundColor = ConsoleColor.DarkGray;
        /// <summary>
        /// The color blue.
        /// </summary>
        public static void Blue() => Console.ForegroundColor = ConsoleColor.Blue;
        /// <summary>
        /// The color green.
        /// </summary>
        public static void Green() => Console.ForegroundColor = ConsoleColor.Green;
        /// <summary>
        /// The color cyan (blue-green).
        /// </summary>
        public static void Cyan() => Console.ForegroundColor = ConsoleColor.Cyan;
        /// <summary>
        /// The color red.
        /// </summary>
        public static void Red() => Console.ForegroundColor = ConsoleColor.Red;
        /// <summary>
        /// The color magenta (purplish-red).
        /// </summary>
        public static void Magenta() => Console.ForegroundColor = ConsoleColor.Magenta;
        /// <summary>
        /// The color yellow.
        /// </summary>
        public static void Yellow() => Console.ForegroundColor = ConsoleColor.Yellow;
        /// <summary>
        /// The color White
        /// </summary>
        public static void White() => Console.ForegroundColor = ConsoleColor.White;
    }
    /// <summary>
    /// Sets the background color of the console
    /// </summary>
    public static class Back
    {
        /// <summary>
        /// The color black.
        /// </summary>
        public static void Black() => Console.BackgroundColor = ConsoleColor.Black;
        /// <summary>
        /// The color dark blue.
        /// </summary>
        public static void DarkBlue() => Console.BackgroundColor = ConsoleColor.DarkBlue;
        /// <summary>
        /// The color dark green.
        /// </summary>
        public static void DarkGreen() => Console.BackgroundColor = ConsoleColor.DarkGreen;
        /// <summary>
        /// The color dark cyan (dark blue-green).
        /// </summary>
        public static void DarkCyan() => Console.BackgroundColor = ConsoleColor.DarkCyan;
        /// <summary>
        /// The color dark red
        /// </summary>
        public static void DarkRed() => Console.BackgroundColor = ConsoleColor.DarkRed;
        /// <summary>
        /// The color dark magenta (dark purplish-red).
        /// </summary>
        public static void DarkMagenta() => Console.BackgroundColor = ConsoleColor.DarkMagenta;
        /// <summary>
        /// The color dark yellow (ochre).
        /// </summary>
        public static void DarkYellow() => Console.BackgroundColor = ConsoleColor.DarkYellow;
        /// <summary>
        /// The color gray.
        /// </summary>
        public static void Gray() => Console.BackgroundColor = ConsoleColor.Gray;
        /// <summary>
        /// The color dark gray.
        /// </summary>
        public static void DarkGray() => Console.BackgroundColor = ConsoleColor.DarkGray;
        /// <summary>
        /// The color blue.
        /// </summary>
        public static void Blue() => Console.BackgroundColor = ConsoleColor.Blue;
        /// <summary>
        /// The color green
        /// </summary>
        public static void Green() => Console.BackgroundColor = ConsoleColor.Green;
        /// <summary>
        /// The color cyan (blue-green).
        /// </summary>
        public static void Cyan() => Console.BackgroundColor = ConsoleColor.Cyan;
        /// <summary>
        /// The color red.
        /// </summary>
        public static void Red() => Console.BackgroundColor = ConsoleColor.Red;
        /// <summary>
        /// The color magenta (purplish-red).
        /// </summary>
        public static void Magenta() => Console.BackgroundColor = ConsoleColor.Magenta;
        /// <summary>
        /// The color yellow.
        /// </summary>
        public static void Yellow() => Console.BackgroundColor = ConsoleColor.Yellow;
        /// <summary>
        /// The color white.
        /// </summary>
        public static void White() => Console.BackgroundColor = ConsoleColor.White;
    }
}