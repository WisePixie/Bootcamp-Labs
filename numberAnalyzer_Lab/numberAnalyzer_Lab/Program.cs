using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name:"); //User input for name
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, " + userName + "! Welcome to the Number Analyzer!"); //greetings!

        bool continueLoop = true;

        while (continueLoop)
        {
            Console.WriteLine("Please enter an integer between 1 and 100:");
            int number = Convert.ToInt32(Console.ReadLine());// # input 1-100

            if (number >= 1 && number <= 100) //Range between 1-100
            {
                if (number % 2 == 0) //Even conditionals
                {
                    if (number > 60) //greater than 60
                    {
                        Console.WriteLine(number + " even and greater than 60.");
                    }
                    else if (number >= 2 && number <= 24) //less than 24
                    {
                        Console.WriteLine(number + " even and less than 25.");
                    }
                    else if (number >= 26 && number <= 60) //between 26 and 60
                    {
                        Console.WriteLine(number + " even and between 26 and 60 inclusive.");
                    }
                }
                else
                {
                    if (number > 60) //Odd conditionals ><greater than and less than 60
                    {
                        Console.WriteLine(number + " odd and greater than 60.");
                    }
                    else if (number < 60)
                    {
                        Console.WriteLine(number + " Odd and less than 60.");
                    }
                }
            }
            else //Invalid input 
            {
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 100.");
            }

            Console.WriteLine("Do you wish to stop? Yes or No, (Y/N)"); //prompt to continue running or end program 
            string response = Console.ReadLine().ToUpper();
            if (response != "Y")
            {
                continueLoop = false;
            }
        }
    }
}
