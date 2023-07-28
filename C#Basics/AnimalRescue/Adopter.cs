using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    internal class Adopter
    {
        private string name;
        private int availiableMoney;

        public Adopter(string name, int availiableMoney)
        {
            this.name = name;
            this.availiableMoney = availiableMoney;
        }

        public string Name { get => name; set => name = value; }
        public int AvailiableMoney { get => availiableMoney; set => availiableMoney = value; }
    }
}
