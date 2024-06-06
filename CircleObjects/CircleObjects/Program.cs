//Objectives: Objects, Methods, Member Variables     
//Task: Calculate a circle's diameter, circumference and area
//The application prompts the user to enter a radius; the user may enter a number with decimals (double)....The application displays an error if the user enters invalid data and asks the user again for a radius....When the user enters valid data, the application creates an instance of a Circle and then uses its methods to display the Diameter, Circumference and Area.....The application asks the user if the circle should grow. If the user says yes, call the grow method then loop back to the method calls for the formulas. The grow method will adjust radius to double its value. If the user says no, the application displays a "goodbye" message that also ddisplays the radius of the circle.


            double radius = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("Welcome to the Circle Tester. Enter radius: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out radius) && radius > 0)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }

            Circle circle = new Circle(radius);
            DisplayCircleInfo(circle);

            bool continueGrowing = true;
            while (continueGrowing)
            {
                Console.Write("Do you want the circle to grow? (y/n): ");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    circle.Grow();
                    DisplayCircleInfo(circle);
                }
                else if (response == "n")
                {
                    continueGrowing = false;
                    Console.WriteLine($"Goodbye! The final radius of the circle is: {circle.GetRadius()}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }
            }


        static void DisplayCircleInfo(Circle circle)
        {
            Console.WriteLine($"Radius: {circle.GetRadius()}");
            Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
            Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
            Console.WriteLine($"Area: {circle.CalculateArea()}");
        }


   
