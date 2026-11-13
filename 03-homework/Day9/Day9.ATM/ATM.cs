using System;

namespace BankomatOperatioin
{
    class Bankomat
    {
        static void ShowMenu()
        {
            Console.WriteLine("\n=== ATM ===\n1. Show balance\n2. Deposite money\n3. Whithdraw money\n0. Exit\n");
        }

        static int ReadChoise()
        {
            Console.Write("Choose operation: ");
            int operation = int.Parse(Console.ReadLine());
            return operation;
        }

        static void ShowBalance(decimal balance)
        {
            Console.WriteLine($"Your balance is {balance}.");
        }

        static decimal Deposit(decimal balance, decimal amount)
        {
            return balance + amount;
        }

        static decimal Whithdraw(decimal balance, decimal whithdraw)
        {
            if ((whithdraw > balance) || (whithdraw <= 0))
            {
                Console.WriteLine("You cant whithdraw.");
                return balance;
            }
            else
            {
                Console.WriteLine("Your whithdraw is complete.");
                return balance -= whithdraw;
            }
        }

        static void Main()
        {
            decimal balance = 250.00m;
            bool isRunning = true;

            while (isRunning)
            {
                ShowMenu();

                int operation = ReadChoise();

                switch (operation)
                {
                    case 1:
                        {
                            ShowBalance(balance);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Write your amount: ");
                            decimal amount = decimal.Parse(Console.ReadLine());
                            balance = Deposit(balance, amount);
                            Console.WriteLine("Your deposite is complite.");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Write your whithdraw: ");
                            decimal whithdraw = decimal.Parse(Console.ReadLine());
                            balance = Whithdraw(balance, whithdraw);
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("You exit, have a nice day!");
                            isRunning = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You make wrong choose, try again!");
                            break;
                        }
                }
            }

            Console.WriteLine($"\nYour total balance is {balance}!");
        }
    }
}