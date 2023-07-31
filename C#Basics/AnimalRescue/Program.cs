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
            Dog dog = new Dog(null, 0, 2, 10, 1, null, "walking", 1.2, "Labrador-mix", false, false, false);
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

            Console.WriteLine("\nShe took it to the vet.");
            Veterinarian vet = new Veterinarian("Doug", "dogs");
            Console.WriteLine(vet.ToString());

            Console.WriteLine("\nThe vet vaccinated and dewormed the dog. The treatment scared the dog.");
            vet.vaccinateDog(dog);
            vet.dewormDog(dog);
            Console.WriteLine(dog.ToString());

            VetAssistant assistant = new VetAssistant("Mary");
            Console.WriteLine("\nThe veterinarian's assistant, " + assistant.Name + ", calmed the dog.");
            assistant.calmDog(dog);
            Console.WriteLine(dog.ToString());

            DogFood wetFood = new DogFood("Wet food", 9, new DateTime(2024, 04, 25, 00, 00, 00), true, "Cow");
            Console.WriteLine("\n" + adopter.Name + " fed the dog with wet food for some time and the dog got fat.");
            dog.Eat(wetFood);
            dog.Weight += 3;
            Console.WriteLine(dog.ToString());

            Console.WriteLine("\nShe had a special routine to help the dog lose more weight: ");            
            Console.WriteLine("\nShe had to feed it special diet food after waking up.");
            DogFood dietFood = new DogFood("Special diet", 22, new DateTime(2024, 06, 24, 00, 00, 00), true, "Duck");
            Console.WriteLine(dog.ToString());

            Console.WriteLine("\nShe then took " + dog.Name + " for a walk.");
            RehabilitationActivity activity = new RehabilitationActivity("walking");
            dog.Rehabilitate(activity);

            Console.WriteLine("\nAfter they returned, " + dog.Name + " went to sleep and " + adopter.Name + " did homework.");
            dog.Sleep();

            Console.WriteLine("\nAfter the dog had woken up, " + adopter.Name + " played fetch with it.");
            dog.Play();

            Console.WriteLine("\nIn the evening, " + adopter.Name + " took " + dog.Name + " for a walk, she fed it the special diet food, and they both went to sleep.");
            dog.Rehabilitate(activity);
            dog.Sleep();
            Console.WriteLine(dog.ToString());

            Console.ReadKey();
        }
    }
}
