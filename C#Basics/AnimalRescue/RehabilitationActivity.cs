using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    internal class RehabilitationActivity
    {
        private string name;

        public RehabilitationActivity(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
