
//Keeps track of a single word and whether it is shown or hidden.
using System.ComponentModel.DataAnnotations;

public class Word
{
  //+++++++ member variables ++++++++
  //to store the text of the word itself
  private string _text;
  //to hold true or false when checking if the word is shown or hidden
  private bool _isHidden;

  //+++++++ constructor ++++++++
  //to initialize values to the internal variables.
  //pass the string text
  public Word(string text)
  {
    _text = text;
    //set words visible
    _isHidden = false;
  }
  
  // +++++++ methods ++++++++++
  // method to hide the word
  public void Hide()
  {
    //reverse the initial value
    _isHidden = true;
  }
  //method to check if the word is hidden or not
  public bool IsHidden()
  {
    //give us the current state of the variable
    return _isHidden;
  }
   //method to show the word with underscores 
  public void Show()
  {
    //return to the initial value
    _isHidden = false;
  }
  
  //method to display the word (with letters or with underscores)
  public string GetDisplayText()
  {
    if (_isHidden == true)
    {
      return new string('_', _text.Length);
    }
    else
    {
      return new string(_text);
    }      
  }  
}
