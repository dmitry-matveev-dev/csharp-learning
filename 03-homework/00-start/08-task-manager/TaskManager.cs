//using System;

//namespace TasksManagerApp
//{
//    class TaskManager
//    {
//        private List<string> _tasks = new List<string>();
//        public void AddTask(string taskName)
//        {
//            _tasks.Add(taskName);
//        }
//        public void ShowTasks()
//        {
//            if (_tasks.Count == 0)
//            {
//                Console.WriteLine("Your tasks is empty!");
//            }
//            else
//            {
//                for (int task = 0; task < _tasks.Count; task++)
//                {
//                    Console.WriteLine($"{task + 1}. {_tasks[task]}");
//                }
//            }
//        }
//        public void RemoveTask(int taskNumber)
//        {
//            _tasks.RemoveAt(taskNumber - 1);
//        }
//    }
//}
