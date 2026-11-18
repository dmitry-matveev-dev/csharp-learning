// Exercism: Scrabble Score
public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int score = 0;
        string scoreWord = input.Trim().ToUpper();
        char[] lettersWord = scoreWord.ToCharArray();
        foreach (char letter in lettersWord)
        {
            if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'L' || letter == 'N' || letter == 'R' || letter == 'S' || letter == 'T')
            {
                score++;
            }
            if (letter == 'D' || letter == 'G')
            {
                score += 2;
            }
            if (letter == 'B' || letter == 'C' || letter == 'M' || letter == 'P')
            {
                score += 3;
            }
            if (letter == 'F' || letter == 'H' || letter == 'V' || letter == 'W' || letter == 'Y')
            {
                score += 4;
            }
            if (letter == 'K')
            {
                score += 5;
            }
            if (letter == 'J' || letter == 'X')
            {
                score += 8;
            }
            if (letter == 'Q' || letter == 'Z')
            {
                score += 10;
            }
        }
        return score;
    }
}



