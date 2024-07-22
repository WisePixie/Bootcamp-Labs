
// Adding new cars
object value = CarInventory.AddCar(new Car("CA", "Corvette", 2024, 24000m));
inventory.AddCar(new Car("Ford", "Mustang", 2023, 35000m));
inventory.AddCar(new Car("Tesla", "Model 3", 2024, 50000m));

// Adding used cars
inventory.AddCar(new UsedCar("Honda", "Civic", 2018, 15000m, 45000, "Good"));
inventory.AddCar(new UsedCar("BMW", "3 Series", 2015, 20000m, 60000, "Fair"));
inventory.AddCar(new UsedCar("Audi", "A4", 2016, 18000m, 55000, "Good"));

Console.WriteLine("Car Inventory:");
inventory.DisplayInventory();

Console.WriteLine("\nEnter the number of the car you want to purchase:");
int choice;
while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > inventory.cars.Count)
{
    Console.WriteLine("Invalid choice. Please enter a valid car number:");
}

Car selectedCar = inventory.GetCar(choice - 1);
if (selectedCar != null)
{
    Console.WriteLine($"\nYou selected: {selectedCar}");
    inventory.RemoveCar(choice - 1);
}

Console.WriteLine("\nUpdated Car Inventory:");
inventory.DisplayInventory();
