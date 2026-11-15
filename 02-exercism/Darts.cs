// Exercism: Darts
public static class Darts
{
    public static int Score(double x, double y)
    {
        double ans = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        if (ans > 10)
        {
            return 0;
        }
        else if ((ans <= 10) && (ans > 5))
        {
            return 1;
        }
        else if ((ans <= 5) && (ans > 1))
        {
            return 5;
        }
        else
        {
            return 10;
        }
    }
}
