namespace ObjectOrientedProgrammingH1day3.Code
{
    internal class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime LastInspection { get; set; }

        public Car(string brand, string model, DateTime productionDate, DateTime lastInspection) : base(brand, model, productionDate, lastInspection)
        {
            Brand = brand;
            Model = model;
            ProductionDate = productionDate;
            LastInspection = lastInspection;
        }
        public override bool InspectionStatus()
        {
            DateTime oneYearFromLastInspection = new DateTime(LastInspection.Year + 2, LastInspection.Month, LastInspection.Day);
            DateTime oneYearAfterProduction = new DateTime(ProductionDate.Year + 4, ProductionDate.Month, ProductionDate.Day);
            if (DateTime.Now > oneYearFromLastInspection && DateTime.Now > oneYearAfterProduction)
            {
                return true;
            }
            return false;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}");
        }

        public override void SetTireType(bool isWinterTire)
        {
            if (isWinterTire) 
            {
                this.MaxRimSize = 16;
            }
            else
            {
                this.MaxRimSize = 22;
            }

        }
    }
}
