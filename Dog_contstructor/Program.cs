using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_contstructor
{
    class Animal
    {

        ////
        
        public static int Count = 0; ///see on staatiline ega vaja objekti, vaid piisab klassist.

        public string name;
        public string color;

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
        }
    }
    class Dog: Animal
    {
        public string breed; ///omadused on väikese tähega

        public Dog(string _name, string _color, string _breed) ////see on konstruktor. Nüüd peab arvuti teadma, et mis on sulgudes on samad omadused, mis klassis kirjeldatud
        {
            name = _name;
            color = _color;
            breed = _breed; ////See on see ühendamise koht. ning kogu see on kontruktor. Konstruktoris tehakse ainult tööd muutujatega mitte lisada Console...rida
            Count++;
        }
        public void PrintInfoAboutDog()
        {
            Console.WriteLine($"Dog's Name: {name}");
            Console.WriteLine($"Dog's color: {color}");
            Console.WriteLine($"Dog's breed: {breed}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog("Luna","white", "Jack Russell");
            rex.PrintInfoAboutDog(); ////rex on objekt.

            Console.WriteLine($"{Animal.Count} has/have been created"); ////loeb kokku kõik loomad, millede loomade sees on count++ konstruktori sees.


            Console.ReadLine();
        }
    }
}
