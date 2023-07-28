﻿using System;
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
            Dog dog = new Dog("Bobby", 7, 7, 3, 5, "Pedigree", "walking", "German shepherd");
            Cat cat = new Cat("Leo", 3, 5, 7, 3, "Whiskas", "climbing", "white and gray");
            Adopter adopter = new Adopter("Millie", 3400);
            DogFood food = new DogFood("Pedigree", 55, new DateTime(2024, 05, 14, 12, 0, 0), true, "chicken liver");
            RehabilitationActivity activity = new RehabilitationActivity("walking");
            Veterinarian vet = new Veterinarian("Doug", "dogs");
            Game game = new Game(adopter, dog, vet);
            
            Console.WriteLine(dog.ToString());

            dog.eat(food);

            Console.WriteLine(dog.ToString());

            Console.ReadKey();
        }
    }
}
