using System;
using System.Linq.Expressions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.\n");
        
        //Step4 5.Test your class by returning to the Main method in the Program.cs file. Create a simple assignment, call the method to get the summary, and then display it to the screen.
        Assignment assignment1 = new Assignment("Samuel", "Multiplication");
        string summary = assignment1.GetSummary();
        Console.WriteLine(summary);

        //Step4 6.Test your class by returning to the Main method and creating a new MathAssignment object and set its values. Make sure to test both the GetSummary() and the GetHomeworkList() methods.
        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19"); 
        string summary2 = mathAssignment1.GetSummary();
        Console.WriteLine(summary2);
        string homeworkList = mathAssignment1.GetHomeworkList();
        Console.WriteLine(homeworkList);

        //Step5 6.Return to Main and test your new class.
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string summary3 = writingAssignment.GetSummary();
        Console.WriteLine(summary3);
        string writingInfoDisplay = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingInfoDisplay);
    }
}