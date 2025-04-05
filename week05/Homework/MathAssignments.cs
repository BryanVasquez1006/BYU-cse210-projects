class MathAssignments : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignments (string textBookSection, string problems, string studentName, string topic) : base(studentName, topic)

    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Text Book Section: {_textBookSection}\nProblems: {_problems}";
    }

}