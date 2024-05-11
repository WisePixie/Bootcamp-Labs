Random random = new Random();
Console.WriteLine("Welcome to the Grand Circus Casino!"); //Welcome statement
Console.WriteLine("");//Break line


while (true)
{
    Console.WriteLine("Enter the number of sides for each die:");//prompt
    int numberOfSides;//numberOfSides
    while (!int.TryParse(Console.ReadLine(), out numberOfSides) || numberOfSides < 1)
    {
        Console.WriteLine("Please enter a valid positive integer.");//enter valid integer
    }

    int die1 = random.Next(1, numberOfSides + 1);//random dice 
    int die2 = random.Next(1, numberOfSides + 1);//random dice
    int total = die1 + die2; //total

    Console.WriteLine($"You rolled: {die1} and {die2}");//output
    Console.WriteLine($"Total: {total}");//total

    if (numberOfSides == 6)//begin program;loop until prompted no... !=y to end
    {//add output to these parameters 
        if (die1 == 1 && die2 == 1)
            Console.WriteLine("Snake Eyes!");
        else if ((die1 == 1 && die2 == 2) || (die1 == 2 && die2 == 1))
            Console.WriteLine("Ace Deuce!");
        else if (die1 == 6 && die2 == 6)
            Console.WriteLine("Box Cars!");
        else if (total == 7 || total == 11)
            Console.WriteLine("You Win!");
        else if (total == 2 || total == 3 || total == 12)
            Console.WriteLine("Craps! Better luck next time.");
    }

    Console.WriteLine("Do you want to roll again? (y/n)");//prompt to roll again
    string input = Console.ReadLine().ToLower();
    if (input != "y")
    {
        Console.WriteLine("Thank you for playing!");//end program
        break;
    }
}