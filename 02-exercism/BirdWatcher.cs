class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        bool isZero = false;
        foreach (int bird in birdsPerDay)
        {
            if (bird == 0)
            {
                isZero = true;
                break;
            }
            else
            {
                isZero = false;
            }
        }
        return isZero;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int bird = 0; bird < numberOfDays; bird++)
        {
            total += birdsPerDay[bird];
        }
        return total;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int bird in birdsPerDay)
        {
            if (bird >= 5)
            {
                busyDays++;
            }
        }
        return busyDays;
    }
}
