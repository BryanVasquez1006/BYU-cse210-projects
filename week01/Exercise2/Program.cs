using System;

class Program
{
    static void Main(string[] args)
    {
        //Declaring variables for the grades
        string gradeLetter = "";

        //Asking the user to enter their grade
        Console.WriteLine("What is your grade? ");
        string userInput = Console.ReadLine();

        //Converting the user's input from a string to an integer
        float userGrade = float.Parse(userInput);

        if (userGrade >= 90)
        {
            gradeLetter = "A";
        }
        else if (userGrade >= 80)
        {
            gradeLetter = "B";

            Console.WriteLine($"The grade is {gradeLetter}");
        }
        else if (userGrade >= 70)
        {
            gradeLetter = "C";
        }
        else if (userGrade >= 60)
        {
            gradeLetter = "D";
        }
        else if (userGrade < 60)
        {
            gradeLetter = "F";
        }

        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else 
        {
            Console.WriteLine("Unfortunately you didn't pass the course. Maybe next time!");
        }
        Console.WriteLine($"Your grade was: {gradeLetter}");
    }
}