using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    [ToString]
    abstract class Animal
    {
        private string name;
        private int age;
        private int weight;
        private int health;
        private int hunger;
        private int happiness;
        private string preferredFood;
        private string preferredRehabilitaton;

        public Animal(string name, int age, int health, int hunger, int happiness, string preferredFood, string preferredRehabilitaton, int weight)
        {
            this.name = name;
            this.age = age;
            this.health = health;
            this.hunger = hunger;
            this.happiness = happiness;
            this.preferredFood = preferredFood;
            this.preferredRehabilitaton = preferredRehabilitaton;
            this.weight = weight;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Health { get => health; set => health = value; }
        public int Hunger { get => hunger; set => hunger = value; }
        public int Happiness { get => happiness; set => happiness = value; }
        public string PreferredFood { get => preferredFood; set => preferredFood = value; }
        public string PreferredRehabilitaton { get => preferredRehabilitaton; set => preferredRehabilitaton = value; }
        public int Weight { get => weight; set => weight = value; }

        public abstract void Eat(AnimalFood food);

        public abstract void Sleep();

        public abstract void Rehabilitate(RehabilitationActivity activity);

        public abstract void Idle();

        public abstract void Play();

        public abstract void Speak();

    }
}
