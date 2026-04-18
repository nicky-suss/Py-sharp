namespace PySharp;

class math
{
    public static double sqrt(int x)
    {
        return Math.Sqrt(x);
    }
    public static double pow(int x, int y)
    {
        return Math.Pow(x, y);
    }
    public static double ceil(double x)
    {
        return Math.Ceiling(x);
    }
    public static double floor(double x)
    {
        return Math.Floor(x);
    }
    public static long factorial(int x)
    {
        long res = 1;
        for (int i = 1; i <= x; i++)
            res *= i;
        return res;
    }
    public static double radians(double degrees) => degrees * Math.PI / 180;
    public static double degrees(double radians) => radians * 180 / Math.PI;
    public static double sin(double x) => Math.Sin(x);
    public static double cos(double x) => Math.Cos(x);
    public static double tan(double x) => Math.Tan(x);
    public const double pi = Math.PI;
    public const double e = Math.E;
}