using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");

        }

        DisplayWelcome();

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        string userName = PromptUserName();
        Console.WriteLine($"Hello {userName}!");

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            string number = Console.ReadLine();
            int convertedNum = int.Parse(number);
            return convertedNum;
        }

        int favNum = PromptUserNumber();
        Console.WriteLine($"Your favorite number is: {favNum}");

        // Accepts an integer as a parameter and returns that number squared (as an integer)

        static int SquareNumber(int number)
        {
            int totalSquared = number * number;
            return totalSquared;
        }

        int squaredNum = SquareNumber(favNum);
        Console.WriteLine($"{userName}, the square of your number is{squaredNum}");
    }
}