using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt randomPrompt = new Prompt();
        Entry entry = new Entry();
        DateTime currentDateTime = DateTime.Now;

        string userChoice;
        string dateText = currentDateTime.ToShortDateString();

        do 
        {
            // Display the menu
            Console.WriteLine("Please select one of the choices below:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            userChoice = Console.ReadLine();
            
            switch (userChoice)
            {
                case "1":
                    // Displaying a random prompt to the user from the prompts list

                    Entry newEntry = new Entry();

                    newEntry._promptText = randomPrompt.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);

                    // Capturing the user's answer to the prompt
                    newEntry._entryText = Console.ReadLine();

                    // Capturing the date and time the user typed on the journal
                    newEntry._date = dateText;
                    newEntry.DisplayEntry();

                    // Adding the entry to the journal
                    journal.entries.Add(newEntry);
                    break;

                case "2":

                    //Displaying all the entries
                    journal.DisplayJournalEntries();
                    break;

                case "3":

                    journal.LoadFromFile();
                    break;
                
                case "4":

                    journal.SaveToFile();
                    break;
            }

        } while (userChoice != "5");
    }
}
