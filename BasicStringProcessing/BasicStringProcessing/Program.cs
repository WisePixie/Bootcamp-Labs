//Prompt the user to enter a sentence.  Split the sentence into individual words and display each word on its own line.

bool continueProgram = true;

while (continueProgram)
{
    // Prompt the user to enter a sentence
    Console.WriteLine("Please enter a sentence:");
    string sentence = Console.ReadLine();

    // Split the sentence into individual words
    string[] words = sentence.Split(' ');

    // Display each word on its own line
    foreach (string word in words)
    {
        Console.WriteLine(word);
    }

    // Ask the user if they want to continue
    Console.WriteLine("Do you want to continue? (y/n)");
    string response = Console.ReadLine().ToLower();


    if (response != "y")
    {
        continueProgram = false;
    }
}


Console.WriteLine("Goodbye!");
        