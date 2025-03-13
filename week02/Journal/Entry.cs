using System.Xml.XPath;

public class Entry
{
   //declare member variables
   public string _message = ""; 

   public string _rnmprompt = "";

   public string _date = "";  

   //make a method to get the date
   public string GetDate()
   {
      DateTime theCurrentTime = DateTime.Now;
      string _dateText = theCurrentTime.ToShortDateString();
      _date = _dateText;
      return _date;
   }
   
   //get the prompt from Promp class
   public string GetPrompt()
   {
      //create an instance of Prompt class.  
      Prompt prompt = new Prompt(); 
      _rnmprompt = prompt.promptPicker();
      return _rnmprompt;
   } 
   
     
   // A method that displays the entries' details 
   public void Display() 
   {
      Console.WriteLine($"Date: {_date} - Prompt: {_rnmprompt}");
      Console.WriteLine(_message);
   }        
}
