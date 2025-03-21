using System.IO;

public class Journal
{
    public List<Entry> entries= new List<Entry>();

    //Display all the entries from the journal
    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
             Console.WriteLine(entry._date); 
             Console.WriteLine(entry._promptText);
             Console.WriteLine(entry._entryText); 
             Console.WriteLine();
        } 
    } 




// Saving all the entries from the user to a file
    public void SaveToFile()
    {
        Console.WriteLine("Enter the filename to save your journal: ");
        string filename = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
          foreach (Entry entry in entries)
          {
            
              outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
          }

        }

        Console.WriteLine($"Journal saved successfully to {filename}");
    }

    public void LoadFromFile()
    {
        Console.WriteLine("Enter the filename to load your journal (e.g., journal.txt):");

        string filename = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length == 3)
            {
                Entry entry  = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                entries.Add(entry);
                
            }
        }
    }

}