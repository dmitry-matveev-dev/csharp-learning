public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
        for (int i = 1; i <= max; i++){
            sum += i;
        }
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;
        for (int sqare = 1; sqare <= max; sqare++){
            sum += sqare * sqare;
        }
        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}
