using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DistributionWarehouse
{
    public class Warehouse
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
            try
            {
                string jsonData = JsonSerializer.Serialize(storagePackages);

                File.WriteAllText(filename, jsonData);

                Console.WriteLine($"Warehouse data saved to {filename}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving warehouse data: {ex.Message}");
            }
        }

        public void ReadFromDisk(string filename)
        {
            try
            {
                string jsonData = File.ReadAllText(filename);

                storagePackages = JsonSerializer.Deserialize<List<StoragePackage>>(jsonData);

                Console.WriteLine($"Warehouse data loaded from {filename}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading warehouse data: {ex.Message}");
            }
        }

        public void PrintSummary(DateTime currentDate)
        {
            Console.WriteLine("Warehouse Summary:\n");
            int i = 1;
            foreach (var package in storagePackages)
            {
                double price = package.CalculatePrice(currentDate);
                Console.WriteLine($"{i}: {package.Product.Name} - Quantity: {package.Quantity} {package.Product.MeasurableUnit}, " +
                                  $"Price: {price:C}, Entry Date: {package.EntryDate:d}, Expiration Date: {package.ExpirationDate:d}");
                i++;
            }
        }
    }
}
