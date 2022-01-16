using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class WorkerManager
    {
        Workers workers = new Workers();
        public WorkerManager()
        {
            Clear();
            while (true)
            {
                Console.WriteLine("Choose action:");
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Q)
                {
                    Environment.Exit(0);
                }
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.NumPad1:
                        workers.ShowAllWorkers();
                        break;
                    case ConsoleKey.NumPad2:
                        workers.AddNewWorker();
                        break;
                    case ConsoleKey.C:
                        Clear();
                        break;
                    default:
                        break;
                }
            }
        }

        public void Clear()
        {
            Console.Clear();
            Console.Write("Menu:" +
                          "\n1 - Show all workers;" +
                          "\n2 - Add new worker;" +
                          "\nc - Clear;" +
                          "\nq - Exit." +
                          "\n");
        }
    }
}
