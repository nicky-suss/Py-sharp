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
    public const double pi = Math.PI;
    public const double e = Math.E;
}