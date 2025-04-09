using System;

class Program
{
    static void Main(string[] args)
    {   


        string userChoice = "";

        while (userChoice != "4")
        {
           //Menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity:");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start Start listing activity");
            Console.WriteLine("4. Quit");
    
             userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
            
            BreathingActivity breathingActivity = new BreathingActivity();

            //Initializing the Breathing Activity

            breathingActivity.RunBreathingActivity();
            break;

            case "2":
            ReflectionActivity ReflectionActivity = new ReflectionActivity();
            //Initializing Reflection activity
            ReflectionActivity.RunReflectionActivity();
            break;

            case "3":

            ListingActivity listingActivity = new ListingActivity();
            listingActivity.RunListingActivity();
            break;

            case "4":
            break;


        } 
        }
    }
    
}