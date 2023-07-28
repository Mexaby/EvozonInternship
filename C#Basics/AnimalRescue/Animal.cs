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
        private int health;
        private int hunger;
        private int happiness;
        private string preferredFood;
        private string preferredRehabilitaton;

        public Animal(string name, int age, int health, int hunger, int happiness, string preferredFood, string preferredRehabilitaton)
        {
            this.name = name;
            this.age = age;
            this.health = health;
            this.hunger = hunger;
            this.happiness = happiness;
            this.preferredFood = preferredFood;
            this.preferredRehabilitaton = preferredRehabilitaton;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Health { get => health; set => health = value; }
        public int Hunger { get => hunger; set => hunger = value; }
        public int Happiness { get => happiness; set => happiness = value; }
        public string PreferredFood { get => preferredFood; set => preferredFood = value; }
        public string PreferredRehabilitaton { get => preferredRehabilitaton; set => preferredRehabilitaton = value; }


        public abstract void eat(AnimalFood animalFood);

        public abstract void sleep();

        public abstract void rehabilitate(RehabilitationActivity activity);

        public abstract void idle();

        public abstract void play(Game game);

    }
}
