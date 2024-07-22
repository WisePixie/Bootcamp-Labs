
namespace Car;

internal class Car
{
// Data members
public string Make { get; set; }
public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        // Override ToString() method
        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price:C}";
        }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}