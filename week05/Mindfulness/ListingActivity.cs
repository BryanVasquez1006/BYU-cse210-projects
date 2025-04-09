class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts;


    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    )
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void RunListingActivity()
    {
        DisplayStartingMessage();
        int actDuration = GetActivityDuration();
        Console.WriteLine("List as many responses as you can for the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        //Giving time to the user to think about the prompt
        ShowSpinner(10);

        Console.Write("You may start in...");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(actDuration);


        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!");
        Thread.Sleep(2000);
        DisplayEndingMessage();


    }

    private string GetRandomPrompt()
    {
        Random random= new Random();

        string randomPrompt = _prompts[random.Next(_prompts.Count)];

        return randomPrompt;
    }

}