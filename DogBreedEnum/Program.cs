using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBreedEnum
{
    enum Breed
    {
        Bulldog,
        Boxer,
        Chihuahua
    }
    class Dog
    {
        public static int Count = 0; ///static aitab seda, et me saame üle klassi seda omadust kätte saada.
        
        public string name;
        public int age;
        public Breed dogBreed;

        public Dog(string _name, int _age, Breed _breed)
        {
            name = _name;
            age = _age;
            dogBreed = _breed;
            Count++;
        }
        public void PrintDogInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Breed: {dogBreed}");
        }
       
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Dog luna = new Dog("Luna", 2, Breed.Chihuahua);
            luna.PrintDogInfo();

            Dog rex = new Dog("Rex", 5, Breed.Bulldog);
            rex.PrintDogInfo();

            Console.WriteLine($"You have {Dog.Count} dog(s).");
            Console.WriteLine((int)Breed.Boxer); /////see on võimalus saada välja selle omaduse nr.
            Console.ReadLine();
        }
        
    }
}
