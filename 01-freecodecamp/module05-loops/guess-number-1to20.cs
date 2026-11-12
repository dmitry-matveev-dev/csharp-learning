//using System;

//class Program
//{
//    static void Main()
//    {
//        Random randnum = new Random();
//        int secretNum = randnum.Next(1, 21);
//        int numGess = 0;
//        int totalGess = 5;
//        bool isRight = false;

//        Console.WriteLine("You play game to gess number from 1 to 20!");
//        Console.WriteLine($"You have {totalGess} gesses!");

//        while (numGess < totalGess)
//        {
//            numGess++;
//            Console.Write("Gess number: ");
//            int peopleGess = int.Parse(Console.ReadLine());

//            if (peopleGess == secretNum)
//            {
//                Console.WriteLine($"You right, you have {numGess} gesses!");
//                isRight = true;
//                break;
//            }
//            else if (peopleGess < secretNum)
//            {
//                Console.WriteLine($"You worse, your gess is lowwer than secret number, you have {totalGess - numGess} gesses!");
//            }
//            else if (peopleGess > secretNum)
//            {
//                Console.WriteLine($"You worse, your gess is upper than secret number, you have {totalGess - numGess} gesses!");
//            }
//        }

//        if (!isRight)
//        {
//            Console.WriteLine($"You lose ths game, the correct number was {secretNum}!");
//        }
//    }
//}
