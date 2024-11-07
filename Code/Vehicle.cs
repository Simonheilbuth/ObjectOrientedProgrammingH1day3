namespace ObjectOrientedProgrammingH1day3.Code
{
    internal abstract class Vehicle : IWheels
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime LastInspection { get; set; }
        public int MaxRimSize { get; set; }
        

        public Vehicle(string brand, string model, DateTime productionDate, DateTime lastInspection)
        {
            Brand = brand;
            Model = model;
            ProductionDate = productionDate;
            LastInspection = lastInspection;
        }

        public abstract bool InspectionStatus();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Production Date: {ProductionDate}");
            Console.WriteLine($"Last Inspection: {LastInspection}");
        }

        public abstract void SetTireType(bool isWinterTire);
       
        public virtual string GetInterfaceInfo()
        {
            IWheels myinterface = this;
            return myinterface.Info();
        }
    }
}



