using System;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number between 1 and 100: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 1 && number <= 100)
            {
                if (number % 2 == 0)
                {
                    if (number >= 2 && number <= 24)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (number >= 26 && number <= 60)
                    {
                        Console.WriteLine("Even and between 26 and 60");
                    }
                }
                else
                {
                    if (number < 60)
                    {
                        Console.WriteLine($"{number} Odd and less than 60");
                    }
                    else (number > 60)
                    {
                        Console.WriteLine($"{number} Odd and greater than 60");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error, please enter valid number");
            }
        }
    }
}