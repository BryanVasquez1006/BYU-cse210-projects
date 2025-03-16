using System;

class Program
{
    static void Main(string[] args)
    {
        //Asking the user for the magic Number
        Random randomGenerator = new Random();
        int guessNumber = randomGenerator.Next(1,100);
        int userGuess = 0;

       do
       {
        //Determining if the user needs to guess higher or lower

       //Asking the user for their guess
       Console.WriteLine("What is your guess?");
       string userInGuess = Console.ReadLine();
        userGuess = int.Parse(userInGuess);

           if (userGuess == guessNumber)
           {
                Console.WriteLine("Ay! You guessed it!");
           }
           else if (userGuess > guessNumber)
           {
                Console.WriteLine("Lower");
           }
           else if (userGuess < guessNumber)
           {
            Console.WriteLine("Higher");
           }
           
       } while (userGuess != guessNumber);
       

    }
}