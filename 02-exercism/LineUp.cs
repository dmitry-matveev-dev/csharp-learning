public static class LineUp
{
    public static string Format(string name, int number)
    {
        int endNumber = number % 10;
        int endTenNumber = number % 100;
        string endWord = "th";

        if ((endTenNumber == 11) || (endTenNumber == 12) || (endTenNumber == 13))
        {
            endWord = "th";
        }
        else
        {
            switch (endNumber)
            {
                case 1:
                    {
                        endWord = "st";
                        break;
                    }
                case 2:
                    {
                        endWord = "nd";
                        break;
                    }
                case 3:
                    {
                        endWord = "rd";
                        break;
                    }
                    }
                default:
                    {
                        endWord = "th";
                        break;
                    }
            }
        }

        return $"{name}, you are the {number}{endWord} customer we serve today. Thank you!";
    }
}
