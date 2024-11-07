using ObjectOrientedProgrammingH1day3.Code;

namespace ObjectOrientedProgrammingH1day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carBrand = "Audi";
            string carModel = "A6";
            DateTime carProductionDate = new DateTime(2018, 7, 1);
            DateTime carLastInspection = new DateTime(2022, 10, 1);
            Vehicle car = new Car(carBrand, carModel, carProductionDate, carLastInspection);
            car.SetTireType( false);




            string truckBrand = "Volvo";
            string truckModel = "H7";
            DateTime truckProductionDate = new DateTime(2019, 10, 1);
            DateTime truckLastInspection = new DateTime(2021, 10, 1);
            Vehicle truck = new Truck(truckBrand, truckModel, truckProductionDate, truckLastInspection);
            truck.SetTireType(false);
            car.DisplayInfo();
            Console.WriteLine($" Needs inspection: {car.InspectionStatus()}");
            Console.WriteLine($"This is cars max rim size: {car.MaxRimSize}");
            truck.DisplayInfo();
            Console.WriteLine($" Needs inspection:{truck.InspectionStatus()}");
            Console.WriteLine($"This is trucks max rim size: {truck.MaxRimSize}");
            Console.WriteLine(car.GetInterfaceInfo());
            Console.ReadKey();
        }
    }
}
