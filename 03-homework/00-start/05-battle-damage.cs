//using System;

//class Battle
//{
//    static int CalculateDamaged(Random randNum, int min, int max)
//    {
//        return randNum.Next(min, max + 1);
//    }

//    static bool isDoged(Random randNum)
//    {
//        double chanceDoged = randNum.NextDouble();

//        if (chanceDoged <= 0.2)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//    static void Main()
//    {
//        Random randNum = new Random();
//        int heroHP = 100;
//        int monsterHP = 100;
//        int turn = 1;

//        Console.WriteLine("Hello dear peoples now you see a battle!");
//        Console.Write("Enter min damage for batlers: ");
//        int min = int.Parse(Console.ReadLine());
//        Console.Write("Enter max damage: ");
//        int max = int.Parse(Console.ReadLine());
//        Console.WriteLine();

//        while ((heroHP > 0) && (monsterHP > 0))
//        {
//            Console.WriteLine($"Hero turn {turn}!");
//            if (isDoged(randNum))
//            {
//                Console.WriteLine("Monster doged the attack!");
//            }
//            else
//            {
//                int lostMonsterHP = CalculateDamaged(randNum, min, max);
//                Console.WriteLine($"Monster is hits, he lost {lostMonsterHP} HP!");
//                monsterHP -= lostMonsterHP;
//            }
//            Console.WriteLine($"After hero turn {turn}, monster have {monsterHP} HP!");

//            Console.WriteLine($"Monster turn {turn}!");
//            if (isDoged(randNum))
//            {
//                Console.WriteLine("Hero doged the attack!");
//            }
//            else
//            {
//                int lostHeroHP = CalculateDamaged(randNum, min, max);
//                Console.WriteLine($"Hero is hits, he lost {lostHeroHP} HP!");
//                heroHP -= lostHeroHP;
//            }
//            Console.WriteLine($"After monster turn {turn}, hero have {heroHP} HР!");

//            turn++;

//            Console.WriteLine();
//        }

//        if (heroHP <= 0)
//        {
//            Console.WriteLine($"MONSTER WIN and hero lose after {turn - 1} turn, monster have {monsterHP} HP!");
//        }
//        else
//        {
//            Console.WriteLine($"HERO WIN and monster lose after {turn - 1} turn, hero have {heroHP} HP!");
//        }
//    }
//}
