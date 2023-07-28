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
            Animal dog = new Animal("Bobby", 8, 7, 2, 6, "Pedigree", "walking");
            Adopter adopter = new Adopter("Millie", 3400);
            AnimalFood food = new AnimalFood("Pedigree", 55, new DateTime(2024, 05, 14, 9, 0, 0), true);
            RehabilitationActivity activity = new RehabilitationActivity("walking");
            Veterinarian vet = new Veterinarian("Doug", "dogs");
            Game game = new Game(adopter, dog, vet);

            Console.WriteLine(dog.ToString());
            Console.WriteLine(adopter.ToString());
            Console.WriteLine(food.ToString());
            Console.WriteLine(activity.ToString());
            Console.WriteLine(vet.ToString());
            Console.WriteLine(game.ToString());

            Console.ReadKey();
        }
    }
}
