public class RunningActivity : Activity
{

    private double _distance;

    public RunningActivity( int length, double distance) : base("Running", length)
    {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        double length = GetActivityLength();
        double speed = (_distance / length) * 60;

        return speed;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        double pace = GetActivityLength() / _distance;
        return pace;
    }
}