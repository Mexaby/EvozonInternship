namespace DistributionWarehouse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Distribution Warehouse!\n");

            Warehouse warehouse = new Warehouse();

            Console.WriteLine("Would you like to generate new data? Note: This will overwrite your existing data! (Y/N): ");
            string filename = "warehouse_data.json";

            switch (Console.ReadLine())
            {
                case "y":
                    int numPackages = 200;
                    warehouse.GeneratePackages(numPackages);
                    warehouse.SaveToDisk(filename);
                    break;
                case "n":
                    warehouse.ReadFromDisk(filename);
                    break;
                default:
                    Console.WriteLine("\nPlease enter a valid option.");
                    break;
            }

            DateTime currentDate = DateTime.Now;

            warehouse.PrintSummary(currentDate);
        }
    }
}