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
    public static double celi(double x)
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
    public const double pi = Math.PI;
    public const double e = Math.E;
}