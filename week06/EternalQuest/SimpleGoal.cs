public class SimpleGoal : Goal
{
    private bool _isComplete;

    //Constructor
    public SimpleGoal(string goalName, string description, string points ): base(goalName, description, points)
    {
        
    }

    //Methods

    public override string GetStringRepresentation()
    {
        
        return $"SimpleGoal,{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()},{IsComplete()}";

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public void SetCompletion(bool complete)
    {   
        _isComplete = complete;
    }
}