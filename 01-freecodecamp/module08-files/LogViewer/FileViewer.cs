using System;

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
            StreamReader reader = new StreamReader(logFile);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            // Count the logged events
        }
    }
}
