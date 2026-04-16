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
    public static int len(dynamic obj)
    {
        if (obj is System.Array a) return a.Length;
        if (obj is string s) return s.Length;
        return obj.Count;
    }
    public static void exit() => System.Environment.Exit(0);

    public const bool True = true;
    public const bool False = false;
}