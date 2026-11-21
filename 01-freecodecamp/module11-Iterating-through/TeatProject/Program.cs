using System;

namespace Cicle
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    break;
                }
            }

            string[] names = {"Alex", "Gector"};
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //Exercise
            for (int num = 1; num <= 100; num++)
            {
                if (num % 3 == 0)
                {
                    if (num % 5 == 0)
                    {
                        Console.WriteLine($"{num} - FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine($"{num} - Fizz");
                    }
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine($"{num} - Buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
