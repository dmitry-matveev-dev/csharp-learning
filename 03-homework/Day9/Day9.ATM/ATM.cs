using System;

namespace BankomatOperatioin
{
    class Bankomat
    {
        static decimal GetAmount(string prompt)
        {
            Console.Write(prompt);
            decimal amount;
            while (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.Write("Error.Enter amount: ");
            }
            return amount;
        }
        static void ShowMenu()
        {
            Console.WriteLine("\n=== ATM ===\n1. Show balance\n2. Deposite money\n3. Whithdraw money\n0. Exit\n");
        }

        static int ReadChoise()
        {
            Console.Write("Choose operation: ");
            int operation;
            while (!int.TryParse(Console.ReadLine(), out operation))
            {
                Console.Write("Error. Choose operation: ");
            }
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
            if (whithdraw > balance)
            {
                Console.WriteLine("Not enough money on your balance!");
                return balance;
            }
            else if (whithdraw <= 0)
            {
                Console.WriteLine("Enter a positive amount!");
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
            string prompt = "Write your amount: ";
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
                            decimal amount = GetAmount(prompt);
                            balance = Deposit(balance, amount);
                            Console.WriteLine("Your deposite is complite.");
                            break;
                        }
                    case 3:
                        {
                            decimal whithdraw = GetAmount(prompt);
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

            Console.WriteLine($"\nYour total balance is {balance:F2}!");
        }
    }
}