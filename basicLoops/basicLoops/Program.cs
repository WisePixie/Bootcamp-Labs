string choice;

do
{
    Console.WriteLine("Hello, World!");

    Console.Write("Would you like to continue? (y/n): ");
    choice = Console.ReadLine();
}
while (choice.ToLower() == "y");

Console.WriteLine("Goodbye!");