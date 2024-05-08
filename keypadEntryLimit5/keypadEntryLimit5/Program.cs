int correctCode = 13579;//Correct code
int userCode;//User input
int attempts = 0;//Start
int maxAttempts = 5;//Max try/attempts

Console.WriteLine("Welcome! Please enter the 5 digit key code to proceed.");

    // While loop to repeatedly ask for the key code until the correct one is entered or 5 max attempts are reached
    while (attempts < maxAttempts)
    {
        Console.Write("Enter the 5 digit key code: ");
        if (int.TryParse(Console.ReadLine(), out userCode)) // Check if the user input an integer
        {
            attempts++; // Attempts counter
        
            if (userCode == correctCode) // Does the input match the correct code
            {
                Console.WriteLine("Welcome! Access granted.");//Yes
                return; // Exit the program if the correct code is entered
            }
            else
            {
                Console.WriteLine("Incorrect code. Please try again."); //Try again 5 max times
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a 5 digit number for the key code.");
        }
    }

// If the loop ends due to reaching max attempts
Console.WriteLine("Too many incorrect attempts. Access denied!");
