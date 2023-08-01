using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace DistributionWarehouse
{
    internal class Product
    {
        public string Name { get; set; }
        public string MeasurableUnit { get; set; }
        public double PricePerUnit { get; set; }

        public Product(string name, string measurableUnit, double pricePerUnit)
        {
            Name = name;
            MeasurableUnit = measurableUnit;
            PricePerUnit = pricePerUnit;
        }

        public override string ToString()
        {
            return $"{Name} ({MeasurableUnit}), Price: {PricePerUnit:C}";
        }
    }

    internal class Fruits : Product
    {
        public string NutritionalQuality { get; set; }

        public Fruits(string name, string measurableUnit, double pricePerUnit, string nutritionalQuality)
            : base(name, measurableUnit, pricePerUnit)
        {
            NutritionalQuality = nutritionalQuality;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Nutritional Quality: {NutritionalQuality}";
        }
    }

    internal class Vegetables : Product
    {
        public string Producer { get; set; }

        public Vegetables(string name, string measurableUnit, double pricePerUnit, string producer)
            : base(name, measurableUnit, pricePerUnit)
        {
            Producer = producer;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Producer: {Producer}";
        }
    }

    internal class Dairy : Product
    {
        public int FatLevel { get; set; }

        public Dairy(string name, string measurableUnit, double pricePerUnit, int fatLevel)
            : base(name, measurableUnit, pricePerUnit)
        {
            FatLevel = fatLevel;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Fat Level: {FatLevel}%";
        }
    }

}

