/*Repeatedly prompt the user to enter a string.
Store the string in a list and display the contents of the list with each element seperated by a space.
Enter some text: 
You have entered: 
Would you like to continue? y/n
Goodbye
*/

List<string> stringList = new List<string>();
bool continueInput = true;

while (continueInput)
{
    Console.Write("Enter some text: ");
    string input = Console.ReadLine();
    stringList.Add(input);

    Console.WriteLine("You have entered: " + string.Join(" ", stringList));

    Console.Write("Would you like to continue? (y/n): ");
    string continueResponse = Console.ReadLine().Trim().ToLower();
    if (continueResponse != "y")
    {
        continueInput = false;
    }
}

Console.WriteLine("Goodbye!");


