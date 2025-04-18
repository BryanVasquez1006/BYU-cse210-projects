using System.IO;
public class GoalManager
{
    //Attributes
    private List<Goal> _goals;
    private int _score;

    //Constructors
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    //Setters and Getters

    public void SetScore(int score)
    {
         _score += score;
    }

    //Methods
    public void StartMenu()
    {
        string userChoice = "";
        //User's menu
        Console.WriteLine("Welcome to the Eternal Quest goal setter!\n");
        
        DisplayPlayerInfo();

        while (userChoice != "6")
        {
            Console.WriteLine($"You have {_score} points");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            userChoice = Console.ReadLine();
            Console.Clear();

            switch (userChoice)
            {
                case "1":
                CreateGoal();
                break;

                case "2":
                ListGoalDetails();
                break;

                case "3":
                SaveGoals();
                break;

                case "4": 
                LoadGoals();
                break;

                case "5":
                RecordEvent();
                break;

                case "6":
                break;
            }
        }

    }

    public void DisplayPlayerInfo() 
    {
    Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        int count = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetGoalName()}");
            count++;
        }

    }

    public void ListGoalDetails()
    {   
        int listNumber = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{listNumber}. {goal.GetDetailsString()}");
            listNumber++;
        }
    }

    public void CreateGoal()
    {

        string userChoice;
        Console.WriteLine("Select a goal type you'd like to set:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3.Checklist Goal");
        userChoice = Console.ReadLine();

        Console.WriteLine("What is the name of your goal?");
        string goalName = Console.ReadLine();
        
        Console.WriteLine("What would be the description of your goal?");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("How many points will you earn for this goal?");
        string points = Console.ReadLine();

        Console.Clear();
        

        switch (userChoice)
        
        {
            case "1":
               SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, points);

               _goals.Add(simpleGoal);
            break;

            case "2":
                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, points);
                _goals.Add(eternalGoal);
            break;  

            case "3":

            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");

            string timesAccomplished = Console.ReadLine();

            Console.WriteLine("What would be the bonus?");

            string bonus = Console.ReadLine();

            int target = int.Parse(timesAccomplished);
            int totalBonus = int.Parse(bonus);

            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, points, totalBonus,0,target);
            _goals.Add(checklistGoal);
            break;
        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        }

        int goalIndex = int.Parse(Console.ReadLine());

        int earnedPoints = _goals[goalIndex - 1].RecordAndReturnPoints();

        SetScore(earnedPoints);

        Console.WriteLine($"Congratulations! You've earned {earnedPoints} points for completing this goal!");

        //Removing the recorded goal
        //_goals.RemoveAt(goalIndex - 1);

    }

    public void SaveGoals()
    {

        string fileName = "goals.txt";

        using(StreamWriter goalsRecord = new StreamWriter(fileName))
        {
            goalsRecord.WriteLine(_score);

            foreach(Goal goal in _goals)
            {
                goalsRecord.WriteLine(goal.GetStringRepresentation());
            }
        }

        

    }

public void LoadGoals()
{
    string fileName = "goals.txt";


    string[] lines = File.ReadAllLines(fileName);

    _goals.Clear(); // Reset the list

    _score = int.Parse(lines[0]); // First line is the score

    for (int i = 1; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split(',');

        string goalType = parts[0];

        if (goalType == "SimpleGoal")
        {
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
            bool isComplete = bool.Parse(parts[4]);

            SimpleGoal sg = new SimpleGoal(name, description, points);
            sg.SetCompletion(isComplete);
            _goals.Add(sg);
        }
        else if (goalType == "ChecklistGoal")
        {
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
            int amountCompleted = int.Parse(parts[4]);
            int target = int.Parse(parts[5]);
            int bonus = int.Parse(parts[6]);

            ChecklistGoal cg = new ChecklistGoal(name, description, points,bonus, amountCompleted, target);
            cg.SetBonus(bonus);
            _goals.Add(cg);
        }
        else if (goalType == "EternalGoal")

        {
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];

            EternalGoal eg = new EternalGoal(name, description, points);
            _goals.Add(eg);
        }

    }
}



}
