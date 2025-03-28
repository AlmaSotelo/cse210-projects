using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
//Has the responsibility for tracking both the name of the person who made the comment and the text of the comment.
class Comment
{
   //+++++++ member variables ++++++++

   public string _name;
   public string _text;
   
   
   // ++++++++ methods ++++++++++
       
   // A method that displays the comments' details 
   public void Display() 
   {
      Console.WriteLine($"Name: {_name} - Comment: {_text}");      
   }        
}