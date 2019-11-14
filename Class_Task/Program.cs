using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Class_Task
{
    class Task
    {
        public string description;

        public Task(string _description)
        {
            description = _description;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Demo\task_list.txt";
            List<string> toDoListInFile = File.ReadAllLines(filePath).ToList();

            List<Task> listOfTasks = new List<Task>();

            foreach (string line in toDoListInFile)
            {
                Task newToDoList = new Task();
                
                Console.WriteLine(line);
            }





          

            int i = 0;

           


            Console.ReadLine();
        }
    }
}
