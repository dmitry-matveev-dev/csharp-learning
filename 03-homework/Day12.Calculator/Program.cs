using System;
using System.ComponentModel;

namespace Calculator
{
    class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine("\n=== CALCULATOR ===\n1. Add\n2. Substract\n3. Multiply\n4. Divide\n5. Show history\n0. Exit");
        }
        static int ChooseOperation()
        {
            Console.Write("\nChoose number of operation: ");
            int operation;
            while (!int.TryParse(Console.ReadLine(), out operation))
            {
                Console.Write("Error incorrect enter! Try again: ");
            }
            return operation;
        }
        static double GetNumber(int num)
        {
            Console.Write($"Enter the {num} number of your operation: ");
            double number;
            while(!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Error incorrect enter! Try again: ");
            }
            return number;
        }
        static double AddOperation(double number1, double number2)
        {
            return number1 + number2;
        }
        static double SubstractOperation(double number1, double number2)
        {
            return number1 - number2;
        }
        static double MultiplyOperation(double number1, double number2)
        {
            return number1 * number2;
        }
        static double DivideOperation(double number1, double number2)
        {
            bool isCorrect = false;
            while (!isCorrect)
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Your 2 number is zero, cant do operation!");
                    Console.Write("Enter 2 number again: ");
                    number2 = GetNumber(2);
                }
                else
                {
                    isCorrect = true;
                }
            }
            return number1 / number2;
        }
        static void ShowHistory(List<double> answers)
        {
            Console.WriteLine("\n=== HISTORY ===");
            for (int operation = 0; operation < answers.Count; operation++)
            {
                Console.WriteLine($"Operation {operation + 1}: {answers[operation]:F2}");
            }
        } 
        static void Main()
        {
            List<double> answers = new List<double>();
            bool isRunning = true;

            while (isRunning)
            {
                ShowMenu();
                int operation = ChooseOperation();

                switch (operation)
                {
                    case 1:
                        {
                            double number1 = GetNumber(1);
                            double number2 = GetNumber(2);
                            double answer = AddOperation(number1, number2);
                            Console.WriteLine($"Answer: {answer}.");
                            answers.Add(answer);
                            break;
                        }
                    case 2:
                        {
                            double number1 = GetNumber(1);
                            double number2 = GetNumber(2);
                            double answer = SubstractOperation(number1, number2);
                            Console.WriteLine($"Answer: {answer}.");
                            answers.Add(answer);
                            break;
                        }
                    case 3:
                        {
                            double number1 = GetNumber(1);
                            double number2 = GetNumber(2);
                            double answer = MultiplyOperation(number1, number2);
                            Console.WriteLine($"Answer: {answer}");
                            answers.Add(answer);
                            break;
                        }
                    case 4:
                        {
                            double number1 = GetNumber(1);
                            double number2 = GetNumber(2);
                            double answer = DivideOperation(number1, number2);
                            Console.WriteLine($"Answer: {answer}");
                            answers.Add(answer);
                            break;
                        }
                    case 5:
                        {
                            ShowHistory(answers);
                            break;
                        }
                    case 0:
                        {
                            isRunning = false;
                            Console.WriteLine("Goodbye, see you next time!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Incorrect number of operation, try again!");
                            break;
                        }
                }
            }
        }
    }
}