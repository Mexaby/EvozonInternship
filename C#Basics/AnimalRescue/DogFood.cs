using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    [ToString]
    internal class DogFood : AnimalFood
    {
        private string flavour;

        public DogFood(string name, int price, DateTime expirationDate, bool isInStock, string mainIngredient) : base(name, price, expirationDate, isInStock)
        {
            this.flavour = mainIngredient;
        }
    }
}
