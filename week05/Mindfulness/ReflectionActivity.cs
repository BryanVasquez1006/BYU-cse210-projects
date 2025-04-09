class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    //Constructor

    public ReflectionActivity() : base(
        "Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
    )
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    //Methods

    public void RunReflectionActivity()
    {

        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        DisplayPrompt();
        Console.WriteLine("When you have something in mind press ENTER to continue");
        Console.ReadLine();

        Console.WriteLine("Now, ponder on each of the following questions as they relate to this experience.");

        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        int duration = GetActivityDuration();
        int questionTime = 10;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            DisplayQuestion();
            ShowSpinner(questionTime);
            Console.Clear();
        }

        DisplayEndingMessage();


        
    }

    public string GetRandomPrompt()
    {
        Random random= new Random();

        string randomPrompt = _prompts[random.Next(_prompts.Count)];

        return randomPrompt;

    }

    public string GetRandomQuestion()
    {
        Random random= new Random();

        string randomQuestion = _questions[random.Next(_questions.Count)];

        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"{prompt}");
    }   

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"{question}");
    }




}