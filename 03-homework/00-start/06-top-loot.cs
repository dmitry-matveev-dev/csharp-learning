//using System;

//class TopLoot
//{
//    static List<int> GenerateLoot(Random randPrice, int count){
//        List<int> prices = new List<int>();
//        for (int item = 0; item < count; item++)
//        {
//            prices.Add(randPrice.Next(50, 1001));
//        }
//        return prices;
//    }
//    static int CalculateTotalGold(List<int> prices)
//    {
//        int totalGold = 0;
//        foreach (int item in prices)
//        {
//            totalGold += item;
//        }
//        return totalGold;
//    }

//    static int[] GetTop3Loot(List<int> prices)
//    {
//        int[] top3Loot = new int[3];

//        prices.Sort();
//        prices.Reverse();

//        for (int i = 0; i < 3; i++)
//        {
//            top3Loot[i] = prices[i];
//        }
//        return top3Loot;
//    }
//    static void Main()
//    {
//        Console.WriteLine("Hello hero you play the loot game!");
//        Random randPrice = new Random();
//        Console.Write("Now enter how mayn monsters you kill: ");
//        int monstersKilled = int.Parse(Console.ReadLine());

//        List<int> loot = GenerateLoot(randPrice, monstersKilled);
//        Console.WriteLine($"Total price for all monsters is {CalculateTotalGold(loot)}$!");
//        int[] expLoot = GetTop3Loot(loot);
//        for (int i = 0; i < expLoot.Length; i++)
//        {
//            Console.WriteLine($"{i + 1} place prise is {expLoot[i]}$!");
//        }
//    }
//}