using System;
using System.ComponentModel;

//Keeps track of the book, chapter, and verse information.
class Reference
{
   //+++++++ member variables ++++++++
   //optional
   private int ? _bookNumber;
   private string _book;
   private int _chapter;
   private int _startVerse;
   // optional
   private int ? _endVerse; 
 
   // +++++++ constructors ++++++++++
   //for when book number does not exist, end verse exists.Ex:Proverbs 3:5-6
   public Reference(string book,int chapter,int startVerse, int endVerse)
   {
      _bookNumber = null;
      _book = book;
      _chapter = chapter;
      _startVerse = startVerse;
      _endVerse = endVerse;
   }
   //for when end verse does not exist. Ex: 1Nephi 5:17  
   public Reference(int bookNumber,string book,int chapter,int startVerse)
   {
      _bookNumber = bookNumber;
      _book = book;
      _chapter = chapter;
      _startVerse = startVerse;
      _endVerse = null;
   }
   //for when book number and end verse do not extist. Ex: Alma 36:1
   public Reference(string book,int chapter,int startVerse)
   {
      _bookNumber = null;
      _book = book;
      _chapter = chapter;
      _startVerse = startVerse;
      _endVerse = null;
   }

   // ++++++++ methods ++++++++++
   //to display the reference
   public string GetDisplayText()
   {
      if (_bookNumber == null && _endVerse != null)
      {
         return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
      }
      else if(_bookNumber == null )
      {
        return $"{_bookNumber}{_book} {_chapter}:{_startVerse}"; 
      }
      else
      {
         return $"{_bookNumber}{_book} {_chapter}:{_startVerse} {_endVerse}"; 
      }
   }
}   
