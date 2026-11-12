//using System;

//class Program
//{
//    static void Sum(double x, double y)
//    {
//        Console.WriteLine($"Answer: {x + y}");
//    }

//    static void Minus(double x, double y)
//    {
//        Console.WriteLine($"Answer: {x - y}");
//    }

//    static void Mnog(double x, double y)
//    {
//        Console.WriteLine($"Answer: {x * y}");
//    }

//    static void Delit(double x, double y)
//    {
//        Console.WriteLine($"Answer: {x / y}");
//    }
//    static void Main()
//    {
//        Console.WriteLine("Calculator:");
//        Console.Write("Enter first nuber: ");
//        double x = double.Parse(Console.ReadLine());
//        Console.Write("Enter second number: ");
//        double y = double.Parse(Console.ReadLine());

//        Console.Write("Choose the operation:");
//        int operation = int.Parse(Console.ReadLine());
//        switch (operation)
//        {
//            case 1:
//                Sum(x, y);
//                break;
//            case 2:
//                Minus(x, y);
//                break;
//            case 3:
//                Mnog(x, y);
//                break;
//            case 4:
//                Delit(x, y);
//                break;
//        }
//    }
//}