using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionWarehouse
{
    internal class StoragePackage
    {
        public Product Product { get; private set; }
        public DateTime EntryDate { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public double Quantity { get; private set; }

        // Constructor
        public StoragePackage(Product product, double quantity, DateTime entryDate, DateTime expirationDate)
        {
            Product = product;
            Quantity = quantity;
            EntryDate = entryDate;
            ExpirationDate = expirationDate;
        }

        public double CalculatePrice(DateTime currentDate)
        {
            double price = Product.PricePerUnit * Quantity;

            if (Product is Fruits)
            {
                int weeksBeforeExpiration = (int)(ExpirationDate - currentDate).TotalDays / 7;
                if (weeksBeforeExpiration <= 5 && weeksBeforeExpiration > 0)
                {
                    double discountPercentage = 10 * weeksBeforeExpiration;
                    double discount = price * (discountPercentage / 100);
                    price -= discount;
                }
                else if (weeksBeforeExpiration <= 0)
                {
                    price = 0; // Expired, throw away
                }
            }
            else if (Product is Vegetables)
            {
                int weeksBeforeExpiration = (int)(ExpirationDate - currentDate).TotalDays / 7;
                if (weeksBeforeExpiration <= 4 && weeksBeforeExpiration > 0)
                {
                    double discountPercentage = 5 * weeksBeforeExpiration;
                    double discount = price * (discountPercentage / 100);
                    price -= discount;
                }
                else if (weeksBeforeExpiration <= 0)
                {
                    price = 0; // Expired, throw away
                }
            }
            else if (Product is Dairy)
            {
                int weeksBeforeExpiration = (int)(ExpirationDate - currentDate).TotalDays / 7;
                if (weeksBeforeExpiration <= 3 && weeksBeforeExpiration > 0)
                {
                    double discountPercentage = 8 * weeksBeforeExpiration;
                    double discount = price * (discountPercentage / 100);
                    price -= discount;
                }
                else if (weeksBeforeExpiration <= 0)
                {
                    price = 0; // Expired, throw away
                }
            }

            return price;
        }
    }
}

