int correctCode = 13579;
int userCode;

Console.WriteLine("Welcome! Please enter the 5 digit key code to proceed.");

// While loop to repeatedly ask for the key code until the correct one is entered
while (true)
    {
        Console.Write("Enter the key code: ");
    
        if (int.TryParse(Console.ReadLine(), out userCode)) // Check if the input is an integer
        {
            if (userCode == correctCode) // Check if the input matches the correct code
            {
            Console.WriteLine("Welcome! Access granted.");
            break; // Exit the loop if the correct code is entered
            }
            else
            {
                Console.WriteLine("Incorrect code. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric key code."); //if invalid
        }
    }
