using System;

class Program
{
    static void Main(string[] args)
    {

        //Creating Reference object
        Reference reference= new Reference("3 Nephi", 3, 7, 0, "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them");



        //Crating scripture object with the reference and the scripture text
        Scripture scripture= new Scripture(reference, reference.GetScriptureText()); 

        //Looping until the scripture is completely hidden

        bool isHidden = scripture.IsCompletelyHidden();

        while (isHidden == false)
        {
            //Display the current scripture text
            Console.Clear();

            Console.WriteLine($"{reference.DisplayText()} {scripture.GetDisplayText()}");
            Console.WriteLine();

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            //If user's input is not quit then hide a random number of words

            scripture.HideRandomWords(3);

            //Updating the status of wheter the scripure is completely hidden
            isHidden = scripture.IsCompletelyHidden();
        }
    }
}