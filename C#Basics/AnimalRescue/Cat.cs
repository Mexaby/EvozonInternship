using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    [ToString]
    internal class Cat : Animal
    {
        private readonly string furColor;

        public Cat(string name, int age, int health, int hunger, int happiness, string preferredFood, string preferredRehabilitaton, string furColor) : base(name, age, health, hunger, happiness, preferredFood, preferredRehabilitaton)
        {
            this.furColor = furColor;
        }

        public string FurColor => furColor;
    }
}
