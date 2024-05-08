while (true)
    {
        // Prompting the user for a number
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Outputting numbers from the input number to 0
        for (int i = number; i >= 0; i--)
        {
            Console.Write(i + " ");
        }
        
        // Move to the next line
        Console.WriteLine();

        // Outputting numbers from 0 to the input number
        for (int i = 0; i <= number; i++)
        {
            Console.Write(i + " ");
        }
            
        // Move to the next line
        Console.WriteLine(); 
           
        // Would you like to continue?
        Console.Write("Would you like to continue (y/n)? ");
        string continuePrompt = Console.ReadLine().ToLower();
        if (continuePrompt != "y")
        {
            Console.WriteLine("Goodbye!");
            break;
        }
    }

