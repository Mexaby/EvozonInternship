using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    [ToString]
    internal abstract class Animal
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


        public void eat(AnimalFood animalFood)
        {
            if (animalFood.Name.Equals(preferredFood))
            {
                hunger -= 5;
                happiness += 4;

            }
            else
            { 
                hunger -= 3;
                happiness += 2;
            }

            health++;

            if (health > 10) health = 10;
            if (hunger < 0) hunger = 0;
            if (happiness > 10) happiness = 10;
        }

        public void sleep()
        {
            hunger += 3;
            if (hunger < 0) hunger = 0;
        }

        public void rehabilitate(RehabilitationActivity activity)
        {
            if (activity.Name.Equals(preferredRehabilitaton))
            {
                health += 5;
                happiness += 4;

            } else
            {
                health += 3;
                happiness += 2;
            }

            if (health > 10) health = 10;
            if (happiness > 10) happiness = 10;

        }

        public void idle()
        {
            happiness--;
            health--;
            hunger -= 3;

            if(hunger < 0) hunger=0;
            if(health < 0) health = 0;
            if(happiness < 0) happiness = 0;
        }

    }
}
