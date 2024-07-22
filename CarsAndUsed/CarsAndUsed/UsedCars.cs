namespace CarInventory
{
    public class UsedCar : Car
    {
        public int Mileage { get; set; }
        public string Condition { get; set; }

        public UsedCar(string make, string model, int year, decimal price, int mileage, string condition)
            : base(make, model, year, price)
        {
            Mileage = mileage;
            Condition = condition;
        }

        public override string ToString()
        {
            return base.ToString() + $", Mileage: {Mileage}, Condition: {Condition}";
        }
    }
}
