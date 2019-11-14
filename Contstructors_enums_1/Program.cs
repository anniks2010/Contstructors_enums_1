using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contstructors_enums_1
{
    class Program
    {
        class Animal
        {
            public string name;
            public int age;
            public int levelOfHappiness;

            public void PrintBasicInfo()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Level of happiness: {levelOfHappiness}");
            }
        }
        class Dog: Animal
        {
            public int numberOfBarks = 0;
            public void WaveTail()
            {
                levelOfHappiness++;
            }

            public void Bark()
            {
                Console.WriteLine($"Woof!");
                numberOfBarks++;
            }
        }
        static void Main(string[] args)
        {
            Dog rex = new Dog();
            rex.levelOfHappiness = 0;
            rex.name = "Rex";
            rex.age = 2;

            for (int i = 0; i < 12; i++)
            {
                rex.WaveTail();

                if (rex.levelOfHappiness % 3==0)
                {
                    rex.Bark();
                }

            }
            rex.PrintBasicInfo();
            Console.WriteLine($"{rex.name} has barked {rex.numberOfBarks} times");
            Console.ReadLine();
        }
        
    }
}
