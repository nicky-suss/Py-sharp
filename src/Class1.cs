namespace PySharp;

public static class Base
{
    public static void print(object? obj = null)
    {
        System.Console.WriteLine(obj ?? "");
    }
    public static string input(string? obj = null)
    {
        if (obj != null)
        {
            System.Console.Write(obj);
        }
        return System.Console.ReadLine() ?? "";
    }
    public static int Int(object obj)
    {
        return (int)Convert.ToInt32(obj);
    }
    public static float Float(object obj)
    {
        return Convert.ToSingle(obj);
    }
    public static string str(object obj)
    {
        return Convert.ToString(obj);
    }

    public const bool True = true;
    public const bool False = false;
}