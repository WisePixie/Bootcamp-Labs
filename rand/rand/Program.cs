//create a random number from 1 to 10
Random random = new Random();

int secretNumber = random.Next(1, 11);

Console.WriteLine("What is my secret number?");

//capture the user input and turn it into an integer
string userInput = Console.ReadLine();
int number = int.Parse(userInput);

//3 outcomes
//> < >= <= != ==
// || means OR && means AND
if (secretNumber == number && secretNumber % 2 == 0)
{
    Console.WriteLine("You got it! You're a winner! Your number was even!");
}
else if (secretNumber == number && secretNumber % 2 != 0)
{
    Console.WriteLine("You got it! Your number was odd!");
}
else if (number > secretNumber)
{
    Console.WriteLine("You went over.");
}
else
{
    Console.WriteLine("You went under!");
}