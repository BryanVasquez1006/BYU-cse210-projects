public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(double speed, double length) : base("Cycling Activity", length)
    {
        _speed = speed;

    }

    public override double GetSpeed()
    {

    return _speed;
    
    }

    public override double GetDistance()
    {
        double activityLength = GetActivityLength();
        double distance = _speed * activityLength / 60;
        return distance;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }




}