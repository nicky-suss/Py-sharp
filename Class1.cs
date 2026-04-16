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
            System.Console.WriteLine(obj);
        }
        return System.Console.ReadLine();
    }
}