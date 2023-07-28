using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    [ToString]
    internal class Adopter
    {
        private string name;
        private int age;
        private int availiableMoney;

        public Adopter(string name, int availiableMoney, int age)
        {
            this.name = name;
            this.availiableMoney = availiableMoney;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public int AvailiableMoney { get => availiableMoney; set => availiableMoney = value; }
        public int Age { get => age; set => age = value; }
    }
}
