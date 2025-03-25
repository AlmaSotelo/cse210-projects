using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32.SafeHandles;

// this class Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
class Scripture
{
   //+++++++ member variables ++++++++
   //to store the reference built in Reference class
   private Reference _reference;
   //to store the list of the words in the text living in Word class
   private List<Word> _words;

   // ++++++ constructor ++++++++++
   //constructor that accepts both, a reference and the string text of the scripture
   public Scripture(Reference reference, string text)
   {
      //assign the passed reference to internal variable _reference

      _reference = reference;

      //assign passed text to internal variable _words by converting the string into a List        
      _words = text.Split(' ').Select(wordInText => new Word(wordInText)).ToList();
   }

   // ++++++ methods ++++++++++

   // method to hide random words
   //pass how many words to hide as numberToHide    
   public void HideRandomWords(int numberToHide)
   {
      //make a temporaly collection to know what words are not hidden to select from there
      var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
      //explanation:
      //var visibleWords = from word in _words
      //where !word.IsHidden()

      //in case there are less words shown than the numberToHide, there is not need to select randmly, just hide all of them.   
      if (visibleWords.Count <= numberToHide)
      {
         foreach (var word in visibleWords)
         {
            word.Hide();
         }
      }
      else
      {
         //create an instance of random class
         Random random = new Random();
         //go thorugh the list visibleWords numberToHide times and pick each time a word from there, 
         //once a words is selected, hide it.
         for (int i = 0; i < numberToHide; i++)
         {
            //pick a random word
            int index = random.Next(visibleWords.Count);
            //hide the picked word
            visibleWords[index].Hide();
            //take out the picked word from the visibleWord collection
            visibleWords.RemoveAt(index);
         }
      }
   }

   // method to unhide random words that where already hidden
   //pass how many words to unhide as numberToUnhide 
   public void UnhideRandomWords(int numberToUnhide)
   {
      //make a temporaly collection to know what words are  hidden to select from there
      var hiddenWords = _words.Where(word => word.IsHidden()).ToList();
      //explanation:
      //var hiddenWords = from word in _words
      //where word.IsHidden()

      //in case there are less words hidden than the number to unhide, there is not need to select randmly, just unhide all of them.   
      if (hiddenWords.Count <= numberToUnhide)
      {
         foreach (var word in hiddenWords)
         {
            //change the state of the word
            word.Show();
         }
      }
      else
      {
         //create an instance of random class
         Random random = new Random();
         //go thorugh the list hiddenWords numberToHide times and pick each time a word from there, 
         //once a words is selected, hide it.
         for (int i = 0; i < numberToUnhide; i++)
         {
            //pick a random word
            int index = random.Next(hiddenWords.Count);
            //hide the picked word
            hiddenWords[index].Show();
            //take out the picked word from the hiddenWords collection
            hiddenWords.RemoveAt(index);
         }
      }
   }

   //method to display the text with some words hidden and some words shown
   public string GetDisplayText()
   {
      //get the reference and place it inside a holder
      string scriptureDisplay = $"{_reference.GetDisplayText()}\n";
      //get the display of text and add it to the holder
      //iterate each word in _words and get its display at its current state (shown or hidden)
      scriptureDisplay += string.Join(" ", _words.Select(word => word.GetDisplayText()));

      return scriptureDisplay;
   }

   // method to know when to end the program
   public bool IsCompleteHidden()
   {
      return _words.All(word => word.IsHidden());
   }
}
