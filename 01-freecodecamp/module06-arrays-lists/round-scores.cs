//using System;

//class Program
//{
//    static void Main()
//    {
//        Random randScore = new Random();
//        Console.Write("Enter your rounds: ");
//        int rounds = int.Parse(Console.ReadLine());
//        List<int> roundScores = new List<int>();

//        Console.WriteLine($"Rounds {rounds} will play!");

//        for (int round = 1; round < (rounds + 1); round++)
//        {
//            int score = randScore.Next(0, 101);
//            roundScores.Add(score);
//            Console.WriteLine($"In {round} round player score {score} points!");
//        }
//        Console.WriteLine($"Total rounds logged {roundScores.Count}");

//        roundScores.Sort();
//        roundScores.Reverse();

//        int[] topScores = new int[5];
//        for (int i = 0; i < topScores.Length; i++)
//        {
//            topScores[i] = roundScores[i]; 
//        }

//        for (int i = 0; i < topScores.Length; i++)
//        {
//            Console.WriteLine($"{i +1} position: {topScores[i]} scores!");
//        }
//    }
//}
