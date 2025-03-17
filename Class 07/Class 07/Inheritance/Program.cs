namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WheeledVehicle vehicle = new WheeledVehicle
            //{
            //    Id = 1,
            //    Model = "Yugo",
            //    Type = "Yugo",
            //    Wheels = 4
            //};

            //Car car = new Car
            //{
            //    Id = 2,
            //    Wheels = 4,
            //    Type = "Yugo",
            //    Model = "Yugo",
            //    Color = "Blue",
            //    Doors = 5
            //};

            //Car car = new Car("Yugo", "Yugo", 5, "red");
            //Console.WriteLine(car);

            //Motorcycle moto = new Motorcycle();

            //car.Drive();
            //moto.Drive();
            Car car = new Car("Yugo", "Yugo", 4, "Red", PetrolType.Diesel);

            Console.WriteLine("Hello, World!");
        }
    }
}
