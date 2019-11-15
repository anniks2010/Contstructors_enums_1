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
        public static int Count = 0;
        public string description;

        public Task(string _description)
        {
            description = _description;
            Count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Demo\task_list.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            List<Task> taskList = new List<Task>();

            foreach(string line in lines)
            {
                //Create a task object at the each line that we read from the file.
                Task newTask = new Task(line); ///line on sõne, mida tahan kasutada objekti koostamisel.
                //add object to the tasklist
                taskList.Add(newTask);
            }
            int i = 1;
            int j = 1;

            foreach (Task task in taskList)
            {
                Console.WriteLine($"Task {i} on your ToDo list is to {task.description}");
                i++;
            }
            ///kasutajalt saab uue taski küsida
            Console.WriteLine("Add a new task: ");
            //salvestada kasutaja antud task
            string userTaskInput = Console.ReadLine();
            //teha uus task objekt kasutaja pool tantud sisendiga
            Task userTask = new Task(userTaskInput);
            ///salvestada usertask to the taskList
            taskList.Add(userTask);

            Console.WriteLine("\n Updated task list: ");

            foreach (Task task in taskList)
            {
                Console.WriteLine($"Task {j} on your ToDo list is to {task.description}");
                j++;
            }
            ///create a new list of string to wrietto the file
            List<string> outputToWriteToFile = new List<string>();

            foreach(Task task in taskList)
            {
                outputToWriteToFile.Add($"{task.description}");
            }

            Console.WriteLine("Writing to a file....");
            ///Write  outputToWriteToFile
            File.WriteAllLines(filePath, outputToWriteToFile);
            Console.WriteLine("Your task has been added.");
            Console.ReadLine();

            ////Uue aasta lubadused. Tühi fail teha TXT. paken kasutajale, et ta saaks lisada oma lubatusi ning kasutada classi, objektidena salvestada. Üks omadus klassis, description. Saab lisada ning eemaldada soove listist. Proovi kasutada funktsioone või meetodeid asjadele, mis korduvad









            
        }
    }
}
