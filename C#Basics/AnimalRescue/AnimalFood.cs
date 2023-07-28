using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue
{
    [ToString]
    abstract class AnimalFood
    {
        private string name;
        private int price;
        private DateTime expirationDate;
        private bool isInStock;

        public AnimalFood(string name, int price, DateTime expirationDate, bool isInStock)
        {
            this.name = name;
            this.price = price;
            this.expirationDate = expirationDate;
            this.isInStock = isInStock;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public bool IsInStock { get => isInStock; set => isInStock = value; }
    }
}
