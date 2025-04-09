class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;

    }

    //Getters and setters

    public int GetActivityDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_activityName}\n\n{_description}\n\n");
        
        Console.WriteLine("How long in seconds would you like for your activity?");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();


        Console.Write("Get Ready...");
        ShowCountDown(5);
        Console.Clear();        

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed a {_duration} seconds activity");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = {"|", "/", "-", "\\"};

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        Console.Write(" ");
        while (DateTime.Now < endTime)
        {
        Console.Write("\b" + spinner[i % spinner.Length]);
        Thread.Sleep(1000);
        Console.Write("\b ");
        i++;
        }
        
    }

    public void ShowCountDown(int seconds)
    {
        int counter = seconds;

        while (counter > 0)
        {
            Console.Write(counter);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            counter--;
        }
    }
}