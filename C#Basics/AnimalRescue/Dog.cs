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

        public Dog(string name, int age, int health, int hunger, int happiness, string preferredFood, string preferredRehabilitaton, double weight, string breed) : base(name, age, health, hunger, happiness, preferredFood, preferredRehabilitaton, weight)
        {
            this.breed = breed;
        }

        public string Breed => breed;

        public override void Eat(AnimalFood animalFood)
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
            this.Weight += 0.2;

            if (this.Health > 10) this.Health = 10;
            if (this.Hunger < 0) this.Hunger = 0;
            if (this.Happiness > 10) this.Happiness = 10;
        }

        public override void Sleep()
        {
            Hunger += 3;
            if (Hunger < 0) Hunger = 0;
        }

        public override void Rehabilitate(RehabilitationActivity activity)
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

        public override void Idle()
        {
            Happiness--;
            Health--;
            Hunger -= 3;

            if (Hunger < 0) Hunger = 0;
            if (Health < 0) Health = 0;
            if (Happiness < 0) Happiness = 0;
        }

        public override void Play()
        {
            Happiness += 2;
            Hunger++;
            this.Weight -= 0.2;

            if (Hunger > 10) Hunger = 10;
            if (Happiness > 10) Happiness = 10;
        }

        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
    }


}
