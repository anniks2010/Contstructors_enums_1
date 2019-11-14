using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListOfObjects
{
    class Person
    {
        public static int Count = 0;
        
        public string firstName;
        public string lastname;
        public int age;

        public Person(string _firstName, string _lastName, int _age)
        {
            firstName = _firstName;
            lastname = _lastName;
            age = _age;
            Count++;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Demo\people.txt";
            List<string> listOfPeople = File.ReadAllLines(filePath).ToList();
            ////nüüd teine list nendest objektidest, esimene list oli see, et lugesin andmed failist.

            List<Person> listOfPersonObjects = new List<Person>(); ///sellega lõi lihtsalt listi, foreach-iga tuleb andmed maha lugeda
            foreach(string line in listOfPeople)
            {
                string[] tempArray = line.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                Person newPerson = new Person(tempArray[0], tempArray[1],int.Parse(tempArray[2])); ////loeb andmeid failist vasakult paremale salvestab need uue objekti alla.

                listOfPersonObjects.Add(newPerson);
            }
            
           foreach (Person person in listOfPersonObjects)
            {
                Console.WriteLine($"{person.firstName} {person.lastname} age {person.age} is on you list.");
            }

            Console.ReadLine();
        }
    }
}
