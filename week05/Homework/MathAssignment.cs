using System;
//class that inherit from the base Assignment class
public class MathAssignment : Assignment
{
   //3.Add the attributes as private member variables. Make sure that you do not create new member variables for the ones you inherited from the base class.
   private string _textbookSection;
   private string _problems;

   //4.Create a constructor for your class that accepts all four parameters, have it call the base class constructor to set the base class attributes that way.
   public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
   {
      _textbookSection = textbookSection;
      _problems = problems;
   }

   //Add the GetHomeworkList() method.
   public string GetHomeworkList()
   {
      return $"Section {_textbookSection} Problems {_problems}\n";
   }
}