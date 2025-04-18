public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string goalName, string goalDescription, string points, int bonus,int amountCompleted, int target) : base(goalName, goalDescription, points)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }


    //methods

    public override void RecordEvent()
    {
       _amountCompleted++;

       if (IsComplete())
       {
        Console.WriteLine($"Checklist goal completed! Bonus awarded: {_bonus}");
       }
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()},{_amountCompleted},{_target},{_bonus}";

    }

    public override int RecordAndReturnPoints()
    {
        RecordEvent();

        int totalPoints = int.Parse(GetGoalPoints());

        if (IsComplete() && _amountCompleted == _target)
        {
            totalPoints += _bonus;
        }

        return totalPoints;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
}