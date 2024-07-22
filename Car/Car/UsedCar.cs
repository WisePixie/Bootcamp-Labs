
namespace Car;


public class UsedCar : Car
{
    // Additional data member
    public double Mileage { get; set; }

    // Constructor
    public UsedCar(string make, string model, int year, decimal price, double mileage)
        : base(make, model, year, price)
    {
        Mileage = mileage;
    }

    // Override ToString() method
    public override string ToString()
    {
        return $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price:C}, Mileage: {Mileage:N1} miles";
    }
}
