public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;
        List<int> units = new List<int>();

        foreach (int multiple in multiples)
        {
            if (multiple == 0) continue;

            for (int j = 1; j < max; j++)
            {
                if (j % multiple == 0)
                {
                    bool isRight = false;
                    for (int g = 0; g < units.Count; g++)
                    {
                        if (units[g] == j)
                        {
                            isRight = true;
                            break;
                        }
                    }

                    if (!isRight)
                    {
                        units.Add(j);
                        sum += j;
                    }
                }
            }
        }

        return sum;
    }
}