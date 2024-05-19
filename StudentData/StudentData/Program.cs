/*
 * Task: Write a program that will recognize invalid inputs when the user requests information about students in a class.

What will the application do?
2 Points: Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food
1 Point: Prompt the user to ask about a particular student by number. Convert the input to an integer. Use the integer as the index for the arrays. Print the student’s name.
1 Point: Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
1 Point: Ask the user if they would like to learn about another student.


Build Specifications:
1 Point: Validate user number: Use an if statement to check if the number is out of range, i.e. either less than 1 or greater than the length of the arrays. If so, display a friendly message and let the user try again.
1 Point: Validate category: Ask the user what information category to display: "Hometown" or "Favorite Food". Use an if statement to check that they entered either category name correctly. If they entered an incorrect category, display a friendly message and re-ask the question. (See hints below!)
1 Point: Array Length: Use the first array’s Length property in your code instead of hardcoding it.


Extra Challenges:
1 Point: Provide an option where the user can see a list of all students.
2 Points: Allow the user to search by student name (Good challenge but difficult!)
1 Point: Category names: Allow uppercase and lowercase; allow portion of word such as "Food" instead of "Favorite Food"

*/





// 3 arrays with student info: name, favorite food, hometown
string[] names = { "Darek", "Janet", "Collin", "Terry", "Andre", "Barb", "Lola", "Scarlette", "Ollie" };
string[] hometowns = { "Detroit, MI", "Petoskey, MI", "Chicago, IL", "Chattanooga, TN", "Buffalo, NY", "Aurora, IL", "Boise, ID", "Gatlinburg, TN", "Denver, CO" };
string[] favoriteFoods = { "Burger", "Steak", "Sushi", "Waffle's", "Meatloaf", "Ramen", "Mac n' Cheese", "Taco's", "Omlette" };

int arrayLength = names.Length;

while (true)
{
    try
    {
        //Prompt the user to ask about a particular student by number. Convert into integer.
        //Use the integer as the index for the arrays.
        //Print the student’s name.
        Console.WriteLine("Welcome! Which student would you like to learn more about? Enter a number (1-{0}): ", arrayLength);
        Console.WriteLine("To Exit enter: 0"); 



        int studentNumber = int.Parse(Console.ReadLine());

        if (studentNumber == 0)//exit prompt
        {
            Console.WriteLine("Exiting the program. Goodbye");
            break;
        }

        if (studentNumber < 1 || studentNumber > arrayLength)//invalid user input if int less than 1 or # of students or # in array are not valid
        {
            Console.WriteLine("Invalid. Please enter a number 1-{0}.", arrayLength);//Validate user # try again
            continue;
        }

        int index = studentNumber - 1;
        Console.WriteLine("Name: {0}", names[index]);

        while (true)
        {
            //Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
            Console.WriteLine("What would you like to know? Enter: hometown or favorite food?");
            string category = Console.ReadLine();


            if 
                (ContainsIgnoreCaseAndPartial(category, "hometown") ||
                ContainsIgnoreCaseAndPartial(category, "home") ||
                ContainsIgnoreCaseAndPartial(category, "town"))//exceptions to word input 
            {
                Console.WriteLine("Hometown: {0}", hometowns[index]);
                break;
            }
            else if 
                (ContainsIgnoreCaseAndPartial(category, "favorite food") ||
                ContainsIgnoreCaseAndPartial(category, "food"))
            {
                Console.WriteLine("Favorite food: {0}", favoriteFoods[index]);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'hometown' or 'favorite food'.");//Validate category
            }
        }

        //Ask the user if they would like to learn about another student.
        Console.WriteLine("Would you like to learn about another student? (y/n)");
        string response = Console.ReadLine();

        if (!response.Equals("y", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Exiting the program. Goodbye!");
            break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }

    static bool ContainsIgnoreCaseAndPartial(string source, string toCheck)
    {
        return source.IndexOf(toCheck, StringComparison.OrdinalIgnoreCase) >= 0;
    }

}
    
