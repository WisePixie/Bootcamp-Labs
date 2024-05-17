/*For this challenge, you will need to clone the C# Console Application from the provided GitHub
Repository.Write your methods in the Program.cs file. Feel free to write additional code
outside these methods. In fact you're encouraged to try to call these methods to test them.
Any additional code will not affect your grade.
1. Create a static method named IsPassing() that returns a bool and takes in a grade
(double) as a parameter.
a. If the grade is greater than 65 return true.
b. If the grade is less than or equal to 65 return false.
2. Create a static method named AverageGrades() that takes in 3 parameters, all
doubles: grade1, grade2, grade3.
a. This method should return the average of all grades.
3. Create a static method named OddOrEvenAndPassing() takes in a grade (double) as a
parameter. Convert the grade to an int and run it through the following conditions:
Note: You need to reuse the IsPassing() method here.
a. If the grade is passing and odd return "passing and odd".
b. If the grade is failing and odd return "failing and odd".
c. If the grade is passing and even return "passing and even".
d. If the grade is failing and even return "failing and even".

 

*/



using System;


bool IsPassing(grade);

if (IsPassing) ;
{
    return grade > 65; //a.If the grade is greater than 65 return true.
}

static double AverageGrades(double grade1, double grade2, double grade3)
{
    double average = (grade1 + grade2 + grade3) / 3;
    return average;
}


static string OddOrEvenAndPassing(double grade)
{
    int intGrade = (int)grade;
    bool isPassing = IsPassing(grade);

// Determine if the integer grade is odd or even
    bool isOdd = (intGrade % 2 != 0);

    // Determine the result 
    if (isPassing && isOdd)
    {
        return "passing and odd";
    }
    else if (!isPassing && isOdd)
    {
    return "failing and odd";
    }
    else if (isPassing && !isOdd)
    {
        return "passing and even";
    }
    else
    {
         return "failing and even";
    }
}



        // Example usage of IsPassing method
double grade = 78;
bool isPassing = IsPassing(grade);
Console.WriteLine($"Is the grade {grade} passing? {isPassing}");

double grade1 = 85;
double grade2 = 64;
double grade3 = 90;
double average = AverageGrades(grade1, grade2, grade3);
Console.WriteLine($"The average of grades {grade1}, {grade2}, and {grade3} is {average}");


double testGrade1 = 85;
string result = OddOrEvenAndPassing(testGrade1);
Console.WriteLine($"The grade {testGrade1} is {result}");


double testGrade2 = 64;
string result2 = OddOrEvenAndPassing(testGrade2);
Console.WriteLine($"The grade {testGrade2} is {result2}");


double testGrade3 = 90;
string result3 = OddOrEvenAndPassing(testGrade3);
Console.WriteLine($"The grade {testGrade3} is {result3}");


