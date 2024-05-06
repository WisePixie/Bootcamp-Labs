//Use if else statements to take different actions depending on user input
//Prompt user to enter an integer between 1 and 100









// itegers entered, print input from user
// Odd and less than 60
//Inclusive range of 2 to 24 print even and less than 25
//Inclusive range of 26 to 60 print even and between 26 and 60 inclusive
//Even and greater than 60
//Odd and greater than 60

using System;

class Program
{
    static void Main(string[] args)
    {
        bool programRuns = true;
        bool programRunsAgain;
        string userInput;
        bool isNumber;
        Console.WriteLine("Enter a number between 1 and 100:");
        userInput = Console.ReadLine();
        isNumber = (int.TryParse(Console.ReadLine(), out int number));
         if (isNumber)
        {
            if (number >= 1 && number <= 100)
            {
                if (number <= 60 && number % 2 != 0)
                {
                    Console.WriteLine($"{userInput} Your number is odd and less than 60.");
                }
                else if (number >= 60 && number % 2 == 0)
                {
                    Console.WriteLine($"{userInput} Your number is even and greater than 60.");
                }
                else if (number >= 60 && number % 2 != 0)
                {
                    Console.WriteLine($"{userInput} Your number is odd and greater than 60.");
                }
                else if (number <= 24 && number % 2 == 0)
                {
                    Console.WriteLine($"{userInput} Your number is even and less than 25.");
                }
                else (number % 2 == 0 && number < 25)
                {
                    Console.WriteLine($"{userInput} Your number is between 26 and 60 and even.");
                }
            }
        }
    }
}










/*else (randomNumber >= 26 && randomNumber % 2 == 0);
{
    Console.WriteLine($"{userInput} Your number is between 26 and 60 and even.");
}

*/