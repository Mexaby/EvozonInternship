using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    internal class VetAssistant
    {
        private string name;

        public VetAssistant(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

        public void calmDog(Dog dog)
        {
            dog.IsScared = false;
        }
    }
}
