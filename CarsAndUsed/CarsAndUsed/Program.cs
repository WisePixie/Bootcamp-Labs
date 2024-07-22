using System;

namespace CarInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarInventory inventory = new CarInventory();

            Car newCar = new Car("CA Corvette", "Camry", 2024, 24000m);
            UsedCar usedCar = new UsedCar("Honda", "Civic", 2018, 15000m, 45000, "Good");

            inventory.AddCar(newCar);
            inventory.AddCar(usedCar);

            Console.WriteLine("Car Inventory:");
            inventory.DisplayInventory();
        }
    }
}
