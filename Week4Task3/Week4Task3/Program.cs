using System.Numerics;

namespace Week4Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Create New Car");
            Console.WriteLine("2 - Create New Bicycle");
            Console.WriteLine("3 - Create New Plane");
            Console.WriteLine("4 - View All Vehicles");
            Console.WriteLine("5 - Delete Vehicle");

            Car car = new();
            Bicycle bicycle = new();
            Plane plane = new();
            Vehicle[] vehicles = { car, bicycle, plane };

            while (true)
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Car Drive Time (hour): ");
                        int carDriveTime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Car Drive Path (km): ");
                        int carDrivePath = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Car Door Count: ");
                        byte carDoorCount = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Car Win Code: ");
                        string carWinCode = Console.ReadLine();
                        Console.WriteLine("Car Horse Power: ");
                        int carHorsePower = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Car Tank Size: ");
                        int carTankSize = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Car Current Oil: ");
                        int carCurrentOil = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Car Fuel Type (benzin or diesel): ");
                        string carFuelType = Console.ReadLine();
                        Console.WriteLine("Car Wheel Thickness: ");
                        int carWheelThickness = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Car Transmission Kind (manual or automatic): ");
                        string carTransmissionKind = Console.ReadLine();
                        car = new Car(carDriveTime, carDrivePath, carDoorCount, carWinCode, carTransmissionKind, carWheelThickness, carHorsePower, carTankSize, carCurrentOil, carFuelType);
                        break;
                    case 2:
                        Console.WriteLine("Bicycle Drive Time (hour): ");
                        int bicycleDriveTime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Bicycle Drive Path (km): ");
                        int bicycleDrivePath = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Bicycle Pedal Kind (clipless, flats or hybrid): ");
                        string bicyclePedalKind = Console.ReadLine();
                        Console.WriteLine("Bicycle Wheel Thickness: ");
                        int bicycleWheelThickness = Convert.ToInt32(Console.ReadLine());
                        bicycle = new Bicycle(bicycleDriveTime, bicycleDrivePath, bicyclePedalKind, bicycleWheelThickness);
                        break;
                    case 3:
                        Console.WriteLine("Plane Drive Time (hour): ");
                        int planeDriveTime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Plane Drive Path (km): ");
                        int planeDrivePath = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Plane Wing Length: ");
                        int planeWingLength = Convert.ToInt32(Console.ReadLine());
                        plane = new Plane(planeDriveTime, planeDrivePath, planeWingLength);
                        break;
                    case 4:
                        car.GetFullInfo();
                        plane.GetFullInfo();
                        bicycle.GetFullInfo();
                        break;
                    case 5:
                        //Console.WriteLine("Enter the index of the vehicle you want to delete: ");
                        //int index = Convert.ToInt32(Console.ReadLine());
                        // Indexi sile bilmedimm
                        break;
                    default:
                        Console.WriteLine("Enter the correct option!");
                        break;
                }
            }
        }
    }
}
