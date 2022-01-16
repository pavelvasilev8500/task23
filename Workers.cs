using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class Workers
    {
        private List<Worker> workers = new List<Worker>();

        public Workers()
        {
            workers.Add(new Worker("Igor", 45, "+375298174561", "igor@mail.ru"));
            workers.Add(new Worker("Vasily", 35, "+7(903)987-48-54", "vasily@gmail.com"));
            workers.Add(new Worker("Vadim", 25, "+1-541-895-2541", "vadim@live.com"));
        }

        public void AddNewWorker()
        {
            string name;
            int age;
            string phone; 
            string email;
            Console.WriteLine("Add new worker.");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Age: ");
            int.TryParse(Console.ReadLine(), out age);
            Console.Write("Phone: ");
            phone = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            try
            {
                workers.Add(new Worker(name, age, phone, email));
            }
            catch (WorkerException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void ShowAllWorkers()
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine($"Name: {worker.Name}");
                Console.WriteLine($"Age: {worker.Age}");
                Console.WriteLine($"Phone: {worker.Phone}");
                Console.WriteLine($"Email: {worker.Email}");
                Console.WriteLine();
            }
        }
    }
}
