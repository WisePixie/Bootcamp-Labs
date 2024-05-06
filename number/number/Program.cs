using System;

class Program
{
    static void Main()
    {
        Console.WriteLine
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
                    else
                    {
                        Console.WriteLine($"{number} Odd and greater than 60");
                    }
                }
            }
            else
            {
                Console.WriteLine("Number is out of range (1-100).");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}