using System;

namespace PasswordCheker
{
    class PasswordCreater
    {
        static void ShowMenu()
        {
            Console.WriteLine("\n=== PASSWORD CHECKER ===\n1. Check password\n2. Show rules\n0. Exit");
        }
        static int GetOperation()
        {
            Console.Write("\nEnter operation: ");
            int operation;
            while (!int.TryParse(Console.ReadLine(), out operation))
            {
                Console.WriteLine("Error enter!");
            }
            return operation;
        }

        static string GetPassword()
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            return password;
        }
        static string GetWeakness(int totalWeakness)
        {
            if (totalWeakness <= 2)
            {
                return "Weak";
            }
            else
            {
                return "Strong";
            }
        }
        static void CheckPassword()
        {
            string password = GetPassword();
            string length = password.Length >= 8 ? "OK" : "--";
            string isDigit = password.Any(char.IsDigit) ? "OK" : "--";
            string isUp = password.Any(char.IsUpper) ? "OK" : "--";

            int weakPassword1 = password.Length >= 8 ? 1 : 0;
            int weakPassword2 = password.Any(char.IsDigit) ? 1 : 0;
            int weakPassword3 = password.Any(char.IsUpper) ? 1 : 0;

            string specialSymbols = "!@#$%^&*";
            bool isSpecial = false;
            foreach (char symbol in password)
            {
                if (specialSymbols.Contains(symbol))
                {
                    isSpecial = true;
                    break;
                }
            }
            string isSymbol = isSpecial ? "OK" : "--";
            int weakPassword4 = isSpecial ? 1 : 0;

            int totalWeakness = weakPassword1 + weakPassword2 + weakPassword3 + weakPassword4;

            string weakness = GetWeakness(totalWeakness);

            Console.WriteLine($"Length >= 8:        [{length}]\nContains a digit:    [{isDigit}]\nContains uppercase:  [{isUp}]\nContains symbol:     [{isSymbol}]\n\nStrength: {weakness} ({totalWeakness}/4)");
        }
        static void ShowRules()
        {
            Console.WriteLine("Length >= 8\nContains a digit\nContains uppercase\nContains symbols: !@#$%^&* (one of them)");
        }
        static void Main()
        {
            bool isRunning = true;

            while (isRunning)
            {
                ShowMenu();
                int operation = GetOperation();
                switch (operation)
                {
                    case 1:
                        {
                            CheckPassword();
                            break;
                        }
                    case 2:
                        {
                            ShowRules();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Goodbye have a nice day!");
                            isRunning = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You enter wrong number try again!");
                            break;
                        }
                }
            }
        }
    }
}