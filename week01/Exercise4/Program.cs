using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers. Type 0 when finished");
        string userInput = "";
        int number = 1;
        List<int> numbers = new List<int>();
        

        while (number != 0)
        {
        //Capturing the user's numbers and appending them to the list
        Console.WriteLine("Enter a number");
        userInput = Console.ReadLine();
        number = int.Parse(userInput);
        numbers.Add(number);

        //removing the number 0 from the list
        if (number == 0)
        {
            numbers.Remove(number);
        }

        }

        Console.WriteLine(numbers.Count);
        int totalSum = 0;

        foreach (int num in numbers)
        {
            totalSum = totalSum + num;
        }
        Console.WriteLine($"The total sum is {totalSum}");

        //Calculating the average
        float average = (float)totalSum / (float)numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maximum = numbers[0];

        //Finding the largest number in the list
        foreach (int num in numbers)
        {
            if (num > maximum)
            {
                maximum = num;
            }
        }
            Console.WriteLine($"The maximum number is: {maximum}");
        
    }
}