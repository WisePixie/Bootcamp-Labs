namespace CarInventory;


public class CarInventory
{
    private List<Car> cars;

    public CarInventory()
    {
        cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void DisplayInventory()
    {
        for (int i = 0; i < cars.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {cars[i]}");
        }
    }

    public Car? GetCar(int index)
    {
        if (index >= 0 && index < cars.Count)
        {
            return cars[index];
        }
        else
        {
            return null;
        }
    }

    public void RemoveCar(int index)
    {
        if (index >= 0 && index < cars.Count)
        {
            cars.RemoveAt(index);
        }
    }
}