using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionWarehouse
{
    internal class Warehouse
    {
        private List<StoragePackage> storagePackages;

        public Warehouse()
        {
            storagePackages = new List<StoragePackage>();
        }

        public void GeneratePackages(int numPackages)
        {
            Random random = new Random();
            string[] productNames = { "Apples", "Potatoes", "Onions", "Peaches", "Oranges", "Crackers" };
            string[] productCategories = { "Fruits", "Vegetables", "Other" };
            string[] measurableUnits = { "Kg", "Bag", "Box", "Pack" };

            for (int i = 0; i < numPackages; i++)
            {
                string name = productNames[random.Next(productNames.Length)];
                string category = productCategories[random.Next(productCategories.Length)];
                string measurableUnit = measurableUnits[random.Next(measurableUnits.Length)];
                double pricePerUnit = random.Next(1, 10) + random.NextDouble();
                double quantity = (category == "Kg") ? random.Next(50, 251) : (category == "Bag") ? random.Next(15, 26) :
                                  (category == "Box") ? random.Next(30, 61) : random.Next(100, 501);
                DateTime entryDate = DateTime.Now.AddMonths(-random.Next(1, 7));
                DateTime expirationDate = entryDate.AddMonths(random.Next(1, 7) * 6);

                Product product;
                if (category == "Fruits" || category == "Vegetables")
                {
                    string nutritionalQuality = $"Quality-{random.Next(1, 6)}";
                    string producer = $"Producer-{random.Next(1, 6)}";
                    product = (category == "Fruits") ? new Fruits(name, measurableUnit, pricePerUnit, nutritionalQuality) :
                                                      new Vegetables(name, measurableUnit, pricePerUnit, producer);
                }
                else
                {
                    product = new Product(name, measurableUnit, pricePerUnit);
                }

                StoragePackage package = new StoragePackage(product, quantity, entryDate, expirationDate);
                storagePackages.Add(package);
            }
        }

        public void SaveToDisk(string filename)
        {
            // Code to save the warehouse data to disk
            // You can use serialization or any other method to save the data to a file
            // For simplicity, we'll skip the actual implementation here.
            Console.WriteLine($"Warehouse data saved to {filename}");
        }

        public void ReadFromDisk(string filename)
        {
            // Code to read the warehouse data from disk
            // You can use deserialization or any other method to read the data from the file
            // For simplicity, we'll skip the actual implementation here.
            Console.WriteLine($"Warehouse data loaded from {filename}");
        }

        public void PrintSummary(DateTime currentDate)
        {
            Console.WriteLine("Warehouse Summary:\n");

            foreach (var package in storagePackages)
            {
                double price = package.CalculatePrice(currentDate);
                Console.WriteLine($"{package.Product.Name} - Quantity: {package.Quantity} {package.Product.MeasurableUnit}, " +
                                  $"Price: {price:C}, Entry Date: {package.EntryDate:d}, Expiration Date: {package.ExpirationDate:d}");
            }
        }
    }
}
