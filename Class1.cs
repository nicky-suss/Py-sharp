namespace PySharp;

public static class Base
{
    public static void print(object? obj = null)
    {
        System.Console.WriteLine(obj ?? "");
    }
}