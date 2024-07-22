namespace CarInventory
{
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
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
