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
            // Create an adopter and a veterinarian
            Adopter adopter = new Adopter("Millie", 7, 3400);
            Veterinarian veterinarian = new Veterinarian("Doug", "dogs");

            Console.WriteLine(adopter.ToString());

            // Create a dog and set its properties
            Dog dog = new Dog("Bobby", 7, 7, 3, 5, "Pedigree", "walking", "Mixed Labrador");

            Console.WriteLine(dog.ToString());

            // Create dog food
            DogFood dogFood = new DogFood("Pedigree", 55, new DateTime(2024, 05, 14, 12, 0, 0), true, "chicken liver");

            // Feed the dog with the dog food
            dog.Eat(dogFood);

            Console.WriteLine(dog.ToString());

            // Make the dog sleep
            dog.Sleep();

            // The dog's hunger will increase slightly after sleeping
            // Display the status of the dog after sleeping
            Console.WriteLine(dog.ToString());

            // Take the dog for a walk (rehabilitate)
            RehabilitationActivity walkingActivity = new RehabilitationActivity("walking");
            dog.Rehabilitate(walkingActivity);

            // Display the status of the dog after the walk
            Console.WriteLine(dog.ToString());

            // Play with the dog
            dog.Play();

            // Display the status of the dog after playing
            Console.WriteLine(dog.ToString());

            // Make the dog idle for a while
            dog.Idle();

            // Display the status of the dog after idling
            Console.WriteLine(dog.ToString());

            // The dog will speak (bark)
            dog.Speak();

            // Display the final status of the dog
            Console.WriteLine(dog.ToString());

            Console.ReadKey();
        }
    }
}
