using System;
using System.Collections.Generic;
public class Assignment
{
   //Add the attributes as private member variables.
   protected string _studentName;
   private string _topic;
   
   //Create a constructor for this class that receives a student name and topic and sets the member variables
   public Assignment(string name, string topic)
   {
      _studentName = name;
      _topic = topic;
   }
   //Add the method for GetSummary() to return the student's name and the topic.
   public string GetSummary()
   {
      return $"\n{_studentName} - {_topic}";
   }
   
}