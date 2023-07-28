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

        public override void eat(AnimalFood animalFood)
        {
            if (animalFood.Name.Equals(PreferredFood))
            {
                this.Hunger -= 5;
                this.Happiness += 4;

            }
            else
            {
                this.Hunger -= 3;
                this.Happiness += 2;
            }

            this.Health++;

            if (this.Health > 10) this.Health = 10;
            if (this.Hunger < 0) this.Hunger = 0;
            if (this.Happiness > 10) this.Happiness = 10;
        }

        public override void sleep()
        {
            Hunger += 3;
            if (Hunger < 0) Hunger = 0;
        }

        public override void rehabilitate(RehabilitationActivity activity)
        {
            if (activity.Name.Equals(PreferredRehabilitaton))
            {
                Health += 5;
                Happiness += 4;

            }
            else
            {
                Health += 3;
                Happiness += 2;
            }

            if (Health > 10) Health = 10;
            if (Happiness > 10) Happiness = 10;

        }

        public override void idle()
        {
            Happiness--;
            Health--;
            Hunger -= 3;

            if (Hunger < 0) Hunger = 0;
            if (Health < 0) Health = 0;
            if (Happiness < 0) Happiness = 0;
        }

        public override void play(Game game)
        {
            Happiness += 2;
            Hunger++;

            if (Hunger > 10) Hunger = 10;
            if (Happiness > 10) Happiness = 10;
        }
    }


}
