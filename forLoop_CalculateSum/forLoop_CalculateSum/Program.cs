char choice;
do
{
    Console.Write("Enter a number: ");//Prompt for number input
    int number = int.Parse(Console.ReadLine());//Read user input

    int sum = 0;//Start
    for (int i = 1; i <= number; i++)//Initialize i with value of 1. Check if i is less or equal to input;increment by 1
    {
        sum += i;//Adding 1 to sum
    }

    Console.WriteLine("The sum of all numbers from 1 to " + number + " is: " + sum);//Output of the sum of all numbers from 1 to input

    Console.Write("Would you like to continue? (y/n): ");//Continue?
    choice = Console.ReadLine().ToLower()[0];

} while (choice == 'y');

    Console.WriteLine("Goodbye!");//End
