using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    [ToString]
    internal class Dog : Animal
    {
        private readonly string breed;

        public Dog(string name, int age, int health, int hunger, int happiness, string preferredFood, string preferredRehabilitaton, string breed) : base(name, age, health, hunger, happiness, preferredFood, preferredRehabilitaton)
        {
            this.breed = breed;
        }

        public string Breed => breed;
    }
}
