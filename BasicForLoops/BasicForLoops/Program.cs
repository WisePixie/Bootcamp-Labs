string choice;

        do
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);

            Console.Write("Would you like to continue? (y/n): ");
            choice = Console.ReadLine();
            Console.WriteLine();
        }
        //while (choice.ToLower() == "y");
while (choice.ToLower().Trim() == "y") ;
Console.WriteLine("Goodbye!");

