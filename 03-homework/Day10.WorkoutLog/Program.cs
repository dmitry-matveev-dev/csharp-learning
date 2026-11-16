using System;
using System.IO;

namespace WorkoutLog
{
    class LogWorkouter
    {

        public static string _fileName = "training_log.txt";
        static void ShowMenu()
        {
            Console.WriteLine("\n=== Training Log ===\n1. Add training.\n2. History.\n3. Statistics.\n4. Create new log or choose old log.\n0. Exit\n");
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
        static string NameTraining()
        {
            Console.Write("\nEnter the name of your training: ");
            string nameTraining = Console.ReadLine();
            return nameTraining;
        } 
        static int GetTime()
        {
            Console.Write("Enter time in minutes of your training: ");
            int time;
            while (!int.TryParse(Console.ReadLine(), out time))
            {
                Console.Write("Error.Enter time: ");
            }
            return time;
        }
        static string WorldTime()
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            return time;
        }
        
        static string WorldDate()
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            return date;
        }
        static void AddTraining()
        {
            string nameTraining = NameTraining();
            int time = GetTime();
            string worldTime = WorldTime();
            string worldDate = WorldDate();
            string trainingLine = $"Date:{worldDate}. Time:{worldTime}. Name:{nameTraining}, {time} minutes.\r\n";
            File.AppendAllText(_fileName, trainingLine);    
        }
        static void SeeHistory()
        {
            if (!File.Exists(_fileName))
            {
                Console.WriteLine("You have no trainings!");
            }
            else
            {
                int countTraining = File.ReadAllLines(_fileName).Length;
                if (countTraining == 0)
                {
                    Console.WriteLine("You have no trainings!");
                }
                else
                {
                    using (StreamReader reader = new StreamReader(_fileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
        }
        static void SeeStatistics()
        {
            if (!File.Exists(_fileName))
            {
                Console.WriteLine("You have no trainings!");
            }
            else
            {
                int countTraining = File.ReadAllLines(_fileName).Length;
                if (countTraining == 0)
                {
                    Console.WriteLine("You have no trainings!");
                }
                else
                {
                    string lastTraining = File.ReadLines(_fileName).Last();
                    Console.WriteLine($"You have {countTraining} trainings,\nthe last is {lastTraining}");
                }
            }
        }
        static string NewLog()
        {
            Console.Write("\nEnter the name of your new or old log: ");
            string newName = Console.ReadLine();
            _fileName = newName;
            return newName;
        }
        static void Main()
        {
            bool isRunning = true;

            while (isRunning)
            {
                ShowMenu();
                int choose = ReadChoise();

                switch (choose)
                {
                    case 1:
                        {
                            AddTraining();
                            Console.WriteLine("Your training add to log!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nHistory of your trainings:");
                            SeeHistory();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nStatistics of your trainings:");
                            SeeStatistics();
                            break;
                        }
                    case 4:
                        {
                            string newName = NewLog();
                            Console.WriteLine($"Your new {newName} log is choose!");
                            break;
                        }
                    case 0:
                        {
                            isRunning = false;
                            Console.WriteLine("\nGoodbye, see you next time!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nIncorrect enter, try again!");
                            break;
                        }
                }
            }
        }
    }
}