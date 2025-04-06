using System;
//class that inherit from the base Assignment class
//2.Create the class and set up the inheritance relationship.
public class WritingAssignment : Assignment
{
   //3.Add the member variables and... 
   private string _title;

   //...set up the constructor as you did for the MathAssignment class. It needs to accept all three parameters
   public WritingAssignment(string name, string topic, string title) : base(name, topic)
   {
      _title = title;
   }

   //4.Add the GetWritingInformation() method. It provide the writing information which consist of the title and the student's name
   public string GetWritingInformation()
   {
      return $"{_title} by {_studentName}\n";
   }

}
