class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(int lap, double length) : base("Swimming Activity", length)
    {
        _laps = lap;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        double length = GetActivityLength();

        double speed = (distance / length) * 60;

        return speed;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50  / 1000.0;
        return distance;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        double minutes = GetActivityLength();

        return minutes / distance;
    }


}