using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    [ToString]
    internal class Game
    {
        private Adopter adopter;
        private Animal animal;
        private Veterinarian veterinarian;

        public Game(Adopter adopter, Animal animal, Veterinarian veterinarian)
        {
            this.adopter = adopter;
            this.animal = animal;
            this.veterinarian = veterinarian;
        }

        internal Adopter Adopter { get => adopter; set => adopter = value; }
        internal Animal Animal { get => animal; set => animal = value; }
        internal Veterinarian Veterinarian { get => veterinarian; set => veterinarian = value; }
    }
}
