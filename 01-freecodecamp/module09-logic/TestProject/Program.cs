using System;

namespace Program1
{
    class Program
    {
        static void Main()
        {
            //1 этап знак равенства
            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            Console.WriteLine(1 == 2);
            Console.WriteLine("a" == "a ");

            string myValue = "a";
            Console.WriteLine(myValue == "a");

            string value1 = " a";
            string value2 = "A ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

            //2 этап знак неравенства
            Console.WriteLine("a" != "a");
            Console.WriteLine("a" != "A");
            Console.WriteLine(1 != 2);

            string myValue1 = "a";
            Console.WriteLine(myValue != "a");

            //3 этап вычисление сравнений
            Console.WriteLine(1 > 2);
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);

            //4 этап метод возвращающий логическое значение
            string pangram = "fox eats birds and cats also.";
            Console.WriteLine(pangram.Contains("fox"));
            Console.WriteLine(pangram.Contains("cow") == false);//логическое отрицание строка также выведет true
            Console.WriteLine(!pangram.Contains("fox"));//также логическое отрицание выведет false 

            //5 этап условный оператор
            int money = 1001;
            int discount = money > 1000 ? 100 : 50;
            Console.WriteLine($"Total discount is {discount}.");

            //6 этап упражнения с условным оператором
            Random coin = new Random();
            int roll = coin.Next(0, 101);
            string total = roll <= 49 ? "heads" : "tail";
            Console.WriteLine($"The side of coin is {total}!");

            Console.Write("Enter your permision: ");
            string permission = Console.ReadLine();
            Console.Write("Enter your level: ");
            int level;
            while (!int.TryParse(Console.ReadLine(), out level))
            {
                Console.WriteLine("Error enter!");
            }
            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome super Admin user!");
                }
                else
                {
                    Console.WriteLine("Welcome admin user!");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact admin to acsess!");
                }
                else
                {
                    Console.WriteLine("You dont have privileges!");
                }
            }
            else
            {
                Console.WriteLine("You dont have privileges!");
            }


        }
    }
}