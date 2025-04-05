using System;

class Program
{
    static void Main(string[] args)
    {
       Assignment assignment= new Assignment("Bryan Vasquez", "Causes of the World War II");

       MathAssignments mathAssignments= new MathAssignments("Section 7.32", "8-19", "Bryan Vasquez", "Fractions");

       WritingAssignment writingAssignment= new WritingAssignment("European History","Mary Waters", "The causes of the World War II");

       Console.WriteLine(assignment.GetSummary());
       
       Console.WriteLine();

       Console.WriteLine($"{mathAssignments.GetSummary()} {mathAssignments.GetHomeworkList()}");

       Console.WriteLine();

       Console.WriteLine($"{writingAssignment.GetSummary()}\n{writingAssignment.GetWritingInformation()}");
    }
}