using System;
using System.Net.Http.Headers;

namespace FileViewer
{
    class Viewer
    {
        static void Main()
        {
            // Log a new event
            string logFile = "log52.txt";
            string timeWorld = DateTime.Now.ToString("HH:mm:ss");
            File.AppendAllText(logFile, $"{timeWorld}, Aplication started\n");
            Console.WriteLine("File logged.\n");
            // Read back every logged event
            Console.WriteLine("History events:\n");
            using (StreamReader reader = new StreamReader(logFile))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            // Count the logged events
            string[] lines = File.ReadAllLines(logFile);
            Console.WriteLine($"{lines.Length} events in your file.");
        }
    }
}
