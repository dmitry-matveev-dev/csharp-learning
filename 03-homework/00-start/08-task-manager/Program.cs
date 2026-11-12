//using System;
//using TasksManagerApp;

//class Programgbf
//{
//    static void Main()
//    {
//        TaskManager tasks = new TaskManager();
//        bool isRunning = true;

//        while (isRunning)
//        {
//            Console.WriteLine("\n1. Add your task\n2. Show your tasks\n3. Remove your task\n4. Exit");
//            Console.Write("\nChoose the action: ");
//            int choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    {
//                        Console.Write("Enter name of your task: ");
//                        string taskName = Console.ReadLine();
//                        tasks.AddTask(taskName);
//                        Console.WriteLine($"Your task '{taskName}' in tasks!");
//                        break;
//                    }
//                case 2:
//                    {
//                        Console.WriteLine("Your tasks:");
//                        tasks.ShowTasks();
//                        break;
//                    }
//                case 3:
//                    {
//                        Console.WriteLine("Your tasks:");
//                        tasks.ShowTasks();
//                        Console.Write("Enter the number of task that you want to delete: ");
//                        int taskNumber = int.Parse(Console.ReadLine());
//                        Console.WriteLine($"Your task '{taskNumber}' delete.");
//                        tasks.RemoveTask(taskNumber);
//                        break;
//                    }
//                case 4:
//                    {
//                        Console.WriteLine("Goodbie!");
//                        isRunning = false;
//                        break;
//                    }
//                default:
//                    {
//                        Console.WriteLine("Error: Incorrect operation was choice!");
//                        break;
//                    }
//            }
//        }
//    }
//}
