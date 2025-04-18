using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity= new RunningActivity(30, 3.0);

        SwimmingActivity swimmingActivity= new SwimmingActivity(5,5.55);

        CyclingActivity cyclingActivity= new CyclingActivity(7.8, 30);

        runningActivity.DisplayActivityInfo();
        swimmingActivity.DisplayActivityInfo();
        cyclingActivity.DisplayActivityInfo();
    }
}