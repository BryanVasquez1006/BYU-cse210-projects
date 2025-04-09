class BreathingActivity : Activity

{
    public BreathingActivity() :base (
        "Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
    )

    {

    }

    //Methods

    public  void RunBreathingActivity()
    {

        DisplayStartingMessage();
        int duration = GetActivityDuration();
        int cycleTime = 5;
        int counter;

        while (duration > 0)
        {
            Console.Write($"Breath In...");
            counter = cycleTime;

            ShowCountDown(5);

            Console.WriteLine("");

            Console.Write("Breathe out...");
            counter = cycleTime;

            ShowCountDown(5);

            Console.WriteLine("\n");
            duration -= cycleTime *2 ;

            
        }
        DisplayEndingMessage();
    }



}