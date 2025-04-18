abstract public class Activity 

{
    private string _activityName;
    private double _activityLength;

    public Activity(string activityName, double activityLength)
    {
        _activityName = activityName;
        _activityLength = activityLength;

    }

    public virtual string GetDate()
    {
        DateTime currentDate = DateTime.Now;
        
        string formattedDate = currentDate.ToString("yyyy-MM-dd");

        return formattedDate;

    }

    public double GetActivityLength()
    {
        return _activityLength;
    }

    public string GetActivityName()
    {
        return _activityName;
    }
    public  void DisplayActivityInfo()
    {
        string activityInfo = $"{GetDate()} {GetActivityName()} ({GetActivityLength()} min) - Distance: {GetDistance()} km, Speed:{GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";

        Console.WriteLine(activityInfo);
    }

    public  abstract double GetPace();

    public abstract  double GetSpeed();
    public abstract double GetDistance();


}