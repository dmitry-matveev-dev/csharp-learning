using System;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            Random randNum = new Random();
            int curent = 0;

            do
            {
                curent = randNum.Next(1, 11);
                Console.WriteLine(curent);
            } while (curent != 7);

            //Exercise
            int heroHealth = 10;
            int monsterHealth = 10;
            Random randAttack = new Random();

            do
            {
                if (heroHealth > 0)
                {
                    int hit = randAttack.Next(1, 11);
                    monsterHealth -= hit;
                    int health = monsterHealth < 0 ? 0 : monsterHealth;
                    Console.WriteLine($"Monster lose {hit} hp, he had {health} hp!");
                }
                if (monsterHealth > 0)
                {
                    int hit = randAttack.Next(1, 11);
                    heroHealth -= hit;
                    int health = heroHealth < 0 ? 0 : heroHealth;
                    Console.WriteLine($"Hero lose {hit} hp, he had {health} hp!");
                }
            } while ((heroHealth > 0) && (monsterHealth > 0));

            Console.WriteLine(heroHealth > monsterHealth? "Hero wins!" : "Monster wins!");

            //Exersises
            //Project 1:
            string? readResult;
            bool validEntry = false;
            string valueEntered = "";
            int numValue = 0;
            Console.Write("\nWrite the number from 5 to 10: ");

            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    valueEntered = readResult;
                }

                validEntry = int.TryParse(valueEntered, out numValue);

                if (validEntry == true)
                {
                    if (numValue <= 5 || numValue >= 10)
                    {
                        validEntry = false;
                        Console.WriteLine($"You entered {numValue}. Pleae enter correct number!");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry you write incorrect tip!");
                }
            } while (validEntry == false);

            Console.WriteLine($"Your number {numValue} is correct!");

            //Project 2:
            string? readJob;
            string job = "";
            bool validJob = false;
            Console.WriteLine("\n=== ADMIN, MANAGER, USER ===");

            do
            {
                Console.Write("Enter your job: ");
                readJob = Console.ReadLine();

                if (readJob != null)
                {
                    job = readJob.ToLower().Trim();
                    if (job == "admin" || job == "manager" || job == "user")
                    {
                        Console.WriteLine("Correct enter!");
                        validJob = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect job. Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("No enter, try again!");
                }

            } while (!validJob);

            Console.WriteLine($"Your input ({job}) acpted!");

            //Project 3:
            string[] myStrings = { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};
            int periodLocation = 0;
            string myString = "";

            for (int i = 0; i < myStrings.Length; i++)
            {
                periodLocation = myStrings[i].IndexOf(".");
                myString = myStrings[i];
                string mySentense = "";

                while (periodLocation != -1)
                {
                    mySentense = myString.Substring(0, periodLocation);
                    Console.WriteLine(mySentense);

                    myString = myString.Remove(0, periodLocation + 1).Trim();
                    periodLocation = myString.IndexOf(".");
                }

                mySentense = myString.Trim();
                Console.WriteLine(mySentense);
            }

        }
    }
}