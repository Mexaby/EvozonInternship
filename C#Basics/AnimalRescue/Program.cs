using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(null, 0, 2, 10, 1, null, null, 1.2, "Labrador-mix");
            Adopter adopter = new Adopter("Millie", 3400, 7);
            DogFood food = new DogFood("Pedigree", 55, new DateTime(2024, 05, 14, 12, 0, 0), true, "chicken liver");

            Console.WriteLine(adopter.ToString());
            Console.WriteLine(dog.ToString());

            Console.WriteLine("\nShe adopted it and gave it a name.");
            dog.Name = "Bobby";
            Console.WriteLine(dog.ToString());

            Console.WriteLine("\nShe fed it.");
            dog.Eat(food);
            Console.WriteLine(dog.ToString());

            Console.WriteLine("\nA few years passed (3, to be exact). The dog gained weight and became more energetic.");
            dog.Age = 3;
            dog.Weight += 5;
            dog.Happiness += 7;
            dog.Health += 5;
            Console.WriteLine(dog.ToString());


            Console.WriteLine("\nShe played with it.");
            dog.Play();
            dog.Play();
            Console.WriteLine(dog.ToString());

            Console.ReadKey();
        }
    }
}
