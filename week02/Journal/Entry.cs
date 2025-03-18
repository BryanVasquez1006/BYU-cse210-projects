public class Entry()
{
    public string _date;
    public string _promptText;
    public string _entryText;

    //Display what the user has entered for the last entry

    public  void DisplayEntry() 
    {
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
    }



}