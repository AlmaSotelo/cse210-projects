using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Web Developer";
        job1._company = "IBM";
        job1._startYear = 2020;
        job1._endYear = 2024;
        
        Job job2 = new Job();
        job2._jobTitle = "Tester";
        job2._company = "Google";
        job2._startYear = 2023;
        job2._endYear = 2025;

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses. 
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        // add the two jobs above
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);     
        //display job's details using the Display() from Resume class
        myResume.Display();
        
              
    }
}