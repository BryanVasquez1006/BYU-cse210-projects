abstract  public class Goal 
{
    private string _goalName;
    private string _goalDescription;
    private string _points;

    //Constructor
    public Goal(string goalName, string goalDescription, string points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }

    //Getters and Setters

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public string GetGoalPoints()
    {
        return _points;
    }

    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public void SetPoints(string points)
    {
        _points = points;
    }

    //Methods

    abstract public  void RecordEvent();
    abstract public bool IsComplete();
    public virtual string GetDetailsString()
    {
        string checkBox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkBox} {_goalName} {_goalDescription}";
    }
    abstract public string GetStringRepresentation();

    public virtual int RecordAndReturnPoints()
    {
        RecordEvent();
        return int.Parse(GetGoalPoints());
    }


}