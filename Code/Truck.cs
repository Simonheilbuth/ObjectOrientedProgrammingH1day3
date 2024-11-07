using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingH1day3.Code
{
    internal class Truck : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime LastInspection { get; set; }

        public Truck(string brand, string model, DateTime productionDate, DateTime lastInspection) : base(brand, model, productionDate, lastInspection)
        {
            Brand = brand;
            Model = model;
            ProductionDate = productionDate;
            LastInspection = lastInspection;
        }

        public override bool InspectionStatus()
        {
            DateTime oneYearFromLastInspection = new DateTime(LastInspection.Year + 1, LastInspection.Month, LastInspection.Day);
            DateTime oneYearAfterProduction = new DateTime(ProductionDate.Year + 1, ProductionDate.Month, ProductionDate.Day);
            if (DateTime.Now > oneYearFromLastInspection && DateTime.Now > oneYearAfterProduction)
            {
                return true;
            }
            return false;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Truck: {Brand} {Model}");
        }

        public override void SetTireType(bool isWinterTire)
        {
            if (isWinterTire)
            {
                this.MaxRimSize = 17;
            }
            else
            {
                this.MaxRimSize = 20;
            }
        }
    }
}
