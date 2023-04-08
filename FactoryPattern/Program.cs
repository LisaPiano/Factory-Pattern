namespace FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isANumber;
            int wheelCount;
            do
            { 
                Console.WriteLine("Hello! Please enter the number of wheels that you wish for your vehicle: ");
                isANumber = int.TryParse(Console.ReadLine(), out wheelCount);
            }
            while (!isANumber);
            var newVehicle = VehicleFactory.GetVehicle(wheelCount);
            newVehicle.Drive();
            Console.WriteLine($"The name of the new vehicle is: {newVehicle.Name}");
        }
    }
}
