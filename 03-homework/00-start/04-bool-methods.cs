//using System;

//class Program
//{
//    static bool IsPositive(int number)
//    {
//        return number >= 0;
//    }

//    static bool IsAdult(int age)
//    {
//        return age >= 18;
//    }

//    static bool IsBetween(int min, int max, int number)
//    {
//        return (min < number) && (number < max);
//    }

//    static int Max(int a, int b)
//    {
//        if (a > b)
//        {
//            return a;
//        }
//        else if (b > a)
//        {
//            return b;
//        }
//        else return 0;
//    }
//    static void Main()
//    {
//        Console.Write("Enter number: ");
//        int number = int.Parse(Console.ReadLine());
//        Console.Write("Enter min: ");
//        int min = int.Parse(Console.ReadLine());
//        Console.Write("Enter max: ");
//        int max = int.Parse(Console.ReadLine());
       
//        Console.Write("Enter age: ");
//        int age = int.Parse(Console.ReadLine());

//        Console.Write("Enter a: ");
//        int a = int.Parse(Console.ReadLine());
//        Console.Write("Enter b: ");
//        int b = int.Parse(Console.ReadLine());

//        Console.WriteLine($"IsPositive(5): {IsPositive(number)}");
//        Console.WriteLine($"Is Adult: {IsAdult(age)}");
//        Console.WriteLine($"Is between: {IsBetween(min, max, number)}");
//        Console.WriteLine($"Is max: {Max(a, b)}");
//    }
//}
