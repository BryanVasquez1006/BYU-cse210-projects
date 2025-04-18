public class EternalGoal : Goal
{
    public EternalGoal(string name, string desription, string points) : base(name, desription, points)
    {

    }

    //methods

    public override void RecordEvent()
    {
        IsComplete();

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()}";
    }
}
